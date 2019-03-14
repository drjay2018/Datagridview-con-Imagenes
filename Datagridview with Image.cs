DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de Personal";
            printer.SubTitle = string.Format("Fecha:{0} ", DateTime.Now.Date.ToString("dd/MM/yyyy"));

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Informe de Personal x FP";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;


            printer.PrintDataGridView(dataGridViewEmp);
