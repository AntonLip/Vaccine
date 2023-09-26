using System.Text.RegularExpressions;
using Vaccine.Models.Interfaces.Services;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Vaccine.Services
{
    public class ReportService : IReportService
    {
        private readonly IPatientService _petientService;
        private readonly IVaccinationPlanService _vaccinationPlanService;
        private readonly IVaccineService _vaccineService;
        public ReportService(IPatientService patientService, IVaccinationPlanService vaccinationPlanService, IVaccineService vaccineService)
        {
            _petientService = patientService;
            _vaccinationPlanService = vaccinationPlanService;
            _vaccineService = vaccineService;
        }
        public void GetPatientReport()
        {
            var filePath = "Reports\\ReportPatient.xlsx";
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

                FileVersion fv = new FileVersion();
                fv.ApplicationName = "Microsoft Office Excel";
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                worksheetPart = CreateColumns(worksheetPart);
                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "Отчет по пациентам" };
                sheets.Append(sheet);
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                Row rowFirst = new Row { RowIndex = 1 };
                sheetData.Append(rowFirst);
                InsertCell(rowFirst, 2, "Список пациентов", CellValues.String, 5);
                
                Row rowSecond = new Row { RowIndex = 2 };
                sheetData.Append(rowSecond);

                InsertCell(rowSecond, 1, "№п/п", CellValues.String, 5);
                InsertCell(rowSecond, 2, "Фамилия", CellValues.String, 5);
                InsertCell(rowSecond, 3, "Имя", CellValues.String, 5);
                InsertCell(rowSecond, 4, "Адрес", CellValues.String, 5);
                InsertCell(rowSecond, 5, "Телефон", CellValues.String, 5);
                InsertCell(rowSecond, 6, "Пол", CellValues.String, 5);
                uint idx = 3;
                var patients = _petientService.GetAll();
                foreach (var item in patients)
                {
                    Row row = new Row { RowIndex = idx };
                    sheetData.Append(row);

                    InsertCell(row, 1, (idx - 2).ToString(), CellValues.String, 5);

                    InsertCell(row, 2, item.LastName, CellValues.String, 5);
                    InsertCell(row, 3, item.FirstName, CellValues.String, 5);
                    InsertCell(row, 5, item.Address, CellValues.String, 5);
                    InsertCell(row, 6, item.Phone, CellValues.String, 5);
                    InsertCell(row, 7, item.Sex.ToString(), CellValues.String, 5);


                    idx++;
                }

                workbookPart.Workbook.Save();
                document.Close();
            }
        }
        public void GetPlan(DateTime start, DateTime end)
        {
            var plans = _vaccinationPlanService.GetAll().Where(p => p.NextDone >= start && p.NextDone <= end);
            var filePath = "Reports\\ReportPlan.xlsx";
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();

                FileVersion fv = new FileVersion();
                fv.ApplicationName = "Microsoft Office Excel";
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                worksheetPart = CreateColumns(worksheetPart);
                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "План вакцинации" };
                sheets.Append(sheet);
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                Row rowFirst = new Row { RowIndex = 1 };
                sheetData.Append(rowFirst);
                InsertCell(rowFirst, 2, "План выполнения вакцинации", CellValues.String, 5);

                Row secondFirst = new Row { RowIndex = 2 };
                sheetData.Append(secondFirst);
                InsertCell(secondFirst, 1, $" с {start.Date} по {end.Date}", CellValues.String, 5);

                Row thirdRow = new Row { RowIndex = 3 };
                sheetData.Append(thirdRow);

                InsertCell(thirdRow, 1, "№п/п", CellValues.String, 5);
                InsertCell(thirdRow, 2, "ФИО", CellValues.String, 5);
                InsertCell(thirdRow, 3, "Название вакцины", CellValues.String, 5);
                InsertCell(thirdRow, 4, "Сделано", CellValues.String, 5);
                InsertCell(thirdRow, 5, "Осталось", CellValues.String, 5);
                uint idx = 4;               
                foreach (var item in plans)
                {
                    Row row = new Row { RowIndex = idx };
                    sheetData.Append(row);

                    InsertCell(row, 1, (idx - 3).ToString(), CellValues.String, 5);
                    var patient = _petientService.GetById(item.PatientId);
                    InsertCell(row, 2, $"{patient.FirstName} {patient.LastName}", CellValues.String, 5);
                    var vaccine = _vaccineService.GetById(item.VaccineId);
                    InsertCell(row, 3, vaccine.Name, CellValues.String, 5);
                    InsertCell(row, 4, item.CountDone.ToString(), CellValues.String, 5);
                    InsertCell(row, 5, (item.CountNeed - item.CountDone).ToString(), CellValues.String, 5);
                    idx++;
                }
                workbookPart.Workbook.Save();
                document.Close();
            }
        }
        private static void InsertCell(Row row, int cell_num, string val, CellValues type, uint styleIndex)
        {
            Cell refCell = null;
            Cell newCell = new Cell() { CellReference = cell_num.ToString() + ":" + row.RowIndex.ToString() };
            row.InsertBefore(newCell, refCell);

            // Устанавливает тип значения.
            newCell.CellValue = new CellValue(val);
            newCell.DataType = new EnumValue<CellValues>(type);

        }
        private static string ReplaceHexadecimalSymbols(string txt)
        {
            string r = "[\x00-\x08\x0B\x0C\x0E-\x1F\x26]";
            return Regex.Replace(txt, r, "", RegexOptions.Compiled);
        }
        private static void UpdateCell(WorksheetPart worksheetPart, string text,
            uint rowIndex, string columnName)
        {

            if (worksheetPart != null)
            {
                Cell cell = GetCell(worksheetPart.Worksheet,
                                         columnName, rowIndex);
                cell.CellValue = new CellValue(text);
                worksheetPart.Worksheet.Save();
            }

        }

        private static WorksheetPart GetWorksheetPartByName(SpreadsheetDocument document, string sheetName)
        {
            IEnumerable<Sheet> sheets =
               document.WorkbookPart.Workbook.GetFirstChild<Sheets>().
               Elements<Sheet>().Where(s => s.Name == sheetName);
            if (sheets.Count() == 0)
            {
                return null;
            }
            string relationshipId = sheets.First().Id.Value;
            WorksheetPart worksheetPart = (WorksheetPart)
                 document.WorkbookPart.GetPartById(relationshipId);
            return worksheetPart;
        }

        private  static Cell GetCell(Worksheet worksheet, string columnName, uint rowIndex)
        {
            Row row = GetRow(worksheet, rowIndex);
            if (row == null)
                return null;
            return row.Elements<Cell>().Where(c => string.Compare
                (c.CellReference.Value, columnName +
                rowIndex, true) == 0).First();

        }
        private  static Row GetRow(Worksheet worksheet, uint rowIndex)
        {
            var r = worksheet.GetFirstChild<SheetData>().
             Elements<Row>().Where(r => r.RowIndex == rowIndex).First();
            return r;
        }

        private WorksheetPart CreateColumns(WorksheetPart worksheetPart)
        {
            Columns lstColumns = worksheetPart.Worksheet.GetFirstChild<Columns>();
            Boolean needToInsertColumns = false;
            if (lstColumns == null)
            {
                lstColumns = new Columns();
                needToInsertColumns = true;
            }
            lstColumns.Append(new Column() { Min = 1, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 2, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 3, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 4, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 5, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 6, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 7, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 7, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 7, Max = 10, Width = 20, CustomWidth = true });
            lstColumns.Append(new Column() { Min = 7, Max = 10, Width = 20, CustomWidth = true });
            if (needToInsertColumns)
                worksheetPart.Worksheet.InsertAt(lstColumns, 0);


            return worksheetPart;
        }

        
    }
}
