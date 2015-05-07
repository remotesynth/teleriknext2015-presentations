namespace TelerikReportLibrary
{
    partial class AnotherReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnotherReport));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            this.dataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageHeaderSection = new Telerik.Reporting.PageHeaderSection();
            this.invoiceHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceInfoPanel = new Telerik.Reporting.Panel();
            this.invoiceNrPanel = new Telerik.Reporting.Panel();
            this.invoiceNumberHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceNrTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDatePanel = new Telerik.Reporting.Panel();
            this.invoiceDateHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateTextBox = new Telerik.Reporting.TextBox();
            this.invoiceTotalPanel = new Telerik.Reporting.Panel();
            this.invoiceTotalHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceTotalHeaderTextBox1 = new Telerik.Reporting.TextBox();
            this.panel4 = new Telerik.Reporting.Panel();
            this.pagesHeaderTextBox = new Telerik.Reporting.TextBox();
            this.pagesTextBox = new Telerik.Reporting.TextBox();
            this.companyLogoPictureBox = new Telerik.Reporting.PictureBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.itemNrTextBox = new Telerik.Reporting.TextBox();
            this.itemDescriptionTextBox = new Telerik.Reporting.TextBox();
            this.qtyTextBox = new Telerik.Reporting.TextBox();
            this.unitPriceTextBox = new Telerik.Reporting.TextBox();
            this.lineTotalTextBox = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.pageFooterTextBox = new Telerik.Reporting.TextBox();
            this.reportHeaderSection = new Telerik.Reporting.ReportHeaderSection();
            this.CompanyInfoPanel = new Telerik.Reporting.Panel();
            this.companyNameTextBox = new Telerik.Reporting.TextBox();
            this.groupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.itemsHeaderPanel = new Telerik.Reporting.Panel();
            this.ItemNrHeaderTextBox = new Telerik.Reporting.TextBox();
            this.descriptionHeaderTextBox = new Telerik.Reporting.TextBox();
            this.qtyHeaderTextBox = new Telerik.Reporting.TextBox();
            this.unitPriceHeaderTextBox = new Telerik.Reporting.TextBox();
            this.lineTotalHeaderTextBox = new Telerik.Reporting.TextBox();
            this.groupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.subTotalPanel = new Telerik.Reporting.Panel();
            this.subTotalLabelTextBox = new Telerik.Reporting.TextBox();
            this.subTotalTextBox = new Telerik.Reporting.TextBox();
            this.totalPanel = new Telerik.Reporting.Panel();
            this.totalLabelTextBox = new Telerik.Reporting.TextBox();
            this.totalTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dataSource1
            // 
            this.dataSource1.ConnectionString = "Data Source=bergenhemvm\\sqlexpress;Initial Catalog=Northwind;Integrated Security=" +
    "True";
            this.dataSource1.Name = "dataSource1";
            this.dataSource1.ProviderName = "System.Data.SqlClient";
            this.dataSource1.SelectCommand = "SELECT * FROM [Orders]";
            // 
            // pageHeaderSection
            // 
            this.pageHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(1.1025595664978027D);
            this.pageHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceHeaderTextBox,
            this.invoiceInfoPanel,
            this.companyLogoPictureBox});
            this.pageHeaderSection.Name = "pageHeaderSection";
            // 
            // invoiceHeaderTextBox
            // 
            this.invoiceHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceHeaderTextBox.Name = "invoiceHeaderTextBox";
            this.invoiceHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3779526948928833D), Telerik.Reporting.Drawing.Unit.Inch(0.31488180160522461D));
            this.invoiceHeaderTextBox.Style.Font.Bold = true;
            this.invoiceHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.invoiceHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.invoiceHeaderTextBox.Value = "INVOICE";
            // 
            // invoiceInfoPanel
            // 
            this.invoiceInfoPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceNrPanel,
            this.invoiceDatePanel,
            this.invoiceTotalPanel,
            this.panel4});
            this.invoiceInfoPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.55122053623199463D));
            this.invoiceInfoPanel.Name = "invoiceInfoPanel";
            this.invoiceInfoPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.0949211120605469D), Telerik.Reporting.Drawing.Unit.Inch(0.55133891105651855D));
            this.invoiceInfoPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceInfoPanel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // invoiceNrPanel
            // 
            this.invoiceNrPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceNumberHeaderTextBox,
            this.invoiceNrTextBox});
            this.invoiceNrPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceNrPanel.Name = "invoiceNrPanel";
            this.invoiceNrPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0237796306610107D), Telerik.Reporting.Drawing.Unit.Inch(0.5512993335723877D));
            // 
            // invoiceNumberHeaderTextBox
            // 
            this.invoiceNumberHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00015767414879519492D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceNumberHeaderTextBox.Name = "invoiceNumberHeaderTextBox";
            this.invoiceNumberHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0236220359802246D), Telerik.Reporting.Drawing.Unit.Inch(0.27559053897857666D));
            this.invoiceNumberHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.invoiceNumberHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceNumberHeaderTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceNumberHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceNumberHeaderTextBox.Style.Font.Bold = true;
            this.invoiceNumberHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceNumberHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.invoiceNumberHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceNumberHeaderTextBox.Value = "INVOICE NO";
            // 
            // invoiceNrTextBox
            // 
            this.invoiceNrTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.27566942572593689D));
            this.invoiceNrTextBox.Name = "invoiceNrTextBox";
            this.invoiceNrTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0237795114517212D), Telerik.Reporting.Drawing.Unit.Inch(0.2754722535610199D));
            this.invoiceNrTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.invoiceNrTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceNrTextBox.Value = "=Fields.[OrderID]";
            // 
            // invoiceDatePanel
            // 
            this.invoiceDatePanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceDateHeaderTextBox,
            this.invoiceDateTextBox});
            this.invoiceDatePanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0238977670669556D), Telerik.Reporting.Drawing.Unit.Inch(0.00015783309936523438D));
            this.invoiceDatePanel.Name = "invoiceDatePanel";
            this.invoiceDatePanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0236220359802246D), Telerik.Reporting.Drawing.Unit.Inch(0.55118107795715332D));
            this.invoiceDatePanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceDatePanel.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceDatePanel.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // invoiceDateHeaderTextBox
            // 
            this.invoiceDateHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceDateHeaderTextBox.Name = "invoiceDateHeaderTextBox";
            this.invoiceDateHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0236220359802246D), Telerik.Reporting.Drawing.Unit.Inch(0.27559053897857666D));
            this.invoiceDateHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.invoiceDateHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceDateHeaderTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceDateHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceDateHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceDateHeaderTextBox.Style.Font.Bold = true;
            this.invoiceDateHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceDateHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.invoiceDateHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceDateHeaderTextBox.Value = "DATE";
            // 
            // invoiceDateTextBox
            // 
            this.invoiceDateTextBox.Format = "{0:d}";
            this.invoiceDateTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9259590266738087E-05D), Telerik.Reporting.Drawing.Unit.Inch(0.27555114030838013D));
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0235826969146729D), Telerik.Reporting.Drawing.Unit.Inch(0.2754722535610199D));
            this.invoiceDateTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.invoiceDateTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceDateTextBox.Value = "=Fields.[OrderDate]";
            // 
            // invoiceTotalPanel
            // 
            this.invoiceTotalPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceTotalHeaderTextBox,
            this.invoiceTotalHeaderTextBox1});
            this.invoiceTotalPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0475983619689941D), Telerik.Reporting.Drawing.Unit.Inch(0.00015783309936523438D));
            this.invoiceTotalPanel.Name = "invoiceTotalPanel";
            this.invoiceTotalPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0236217975616455D), Telerik.Reporting.Drawing.Unit.Inch(0.55118083953857422D));
            this.invoiceTotalPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceTotalPanel.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // invoiceTotalHeaderTextBox
            // 
            this.invoiceTotalHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.invoiceTotalHeaderTextBox.Name = "invoiceTotalHeaderTextBox";
            this.invoiceTotalHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0235038995742798D), Telerik.Reporting.Drawing.Unit.Inch(0.27559053897857666D));
            this.invoiceTotalHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.invoiceTotalHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.invoiceTotalHeaderTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceTotalHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.invoiceTotalHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceTotalHeaderTextBox.Style.Font.Bold = true;
            this.invoiceTotalHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceTotalHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.invoiceTotalHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceTotalHeaderTextBox.Value = "TOTAL";
            // 
            // invoiceTotalHeaderTextBox1
            // 
            this.invoiceTotalHeaderTextBox1.Format = "{0:C2}";
            this.invoiceTotalHeaderTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.27566942572593689D));
            this.invoiceTotalHeaderTextBox1.Name = "invoiceTotalHeaderTextBox1";
            this.invoiceTotalHeaderTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0235040187835693D), Telerik.Reporting.Drawing.Unit.Inch(0.275471955537796D));
            this.invoiceTotalHeaderTextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.invoiceTotalHeaderTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceTotalHeaderTextBox1.Value = "=Sum(Fields.[Freight] * Fields.[Freight])";
            // 
            // panel4
            // 
            this.panel4.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pagesHeaderTextBox,
            this.pagesTextBox});
            this.panel4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.0712990760803223D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.panel4.Name = "panel4";
            this.panel4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0236217975616455D), Telerik.Reporting.Drawing.Unit.Inch(0.55118083953857422D));
            // 
            // pagesHeaderTextBox
            // 
            this.pagesHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pagesHeaderTextBox.Name = "pagesHeaderTextBox";
            this.pagesHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0235038995742798D), Telerik.Reporting.Drawing.Unit.Inch(0.27559053897857666D));
            this.pagesHeaderTextBox.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.pagesHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.pagesHeaderTextBox.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pagesHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.pagesHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.pagesHeaderTextBox.Style.Font.Bold = true;
            this.pagesHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.pagesHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.pagesHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.pagesHeaderTextBox.Value = "PAGE";
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.27566942572593689D));
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0235040187835693D), Telerik.Reporting.Drawing.Unit.Inch(0.275471955537796D));
            this.pagesTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.078740157186985016D);
            this.pagesTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.pagesTextBox.Value = "{[PageNumber]} of {[PageCount]}";
            // 
            // companyLogoPictureBox
            // 
            this.companyLogoPictureBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3853931427001953D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.companyLogoPictureBox.MimeType = "image/png";
            this.companyLogoPictureBox.Name = "companyLogoPictureBox";
            this.companyLogoPictureBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8742529153823853D), Telerik.Reporting.Drawing.Unit.Inch(1.1023622751235962D));
            this.companyLogoPictureBox.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.companyLogoPictureBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.companyLogoPictureBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.companyLogoPictureBox.Value = ((object)(resources.GetObject("companyLogoPictureBox.Value")));
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.35433086752891541D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemNrTextBox,
            this.itemDescriptionTextBox,
            this.qtyTextBox,
            this.unitPriceTextBox,
            this.lineTotalTextBox});
            this.detailSection1.Name = "detailSection1";
            this.detailSection1.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.detailSection1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None;
            this.detailSection1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            // 
            // itemNrTextBox
            // 
            this.itemNrTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemNrTextBox.Name = "itemNrTextBox";
            this.itemNrTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1023621559143066D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.itemNrTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemNrTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.itemNrTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.itemNrTextBox.Value = "=Fields.[OrderID]";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1024409532546997D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1496851444244385D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.itemDescriptionTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemDescriptionTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.itemDescriptionTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.itemDescriptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.itemDescriptionTextBox.Value = "=Fields.[ShipCity]";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2522048950195312D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.566693127155304D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.qtyTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.qtyTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.qtyTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.qtyTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.qtyTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.qtyTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.qtyTextBox.Value = "=Fields.[Freight]";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Format = "{0:C2}";
            this.unitPriceTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8189773559570312D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2202754020690918D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.unitPriceTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.unitPriceTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.unitPriceTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.unitPriceTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.unitPriceTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.unitPriceTextBox.Value = "=Fields.[Freight]";
            // 
            // lineTotalTextBox
            // 
            this.lineTotalTextBox.Format = "{0:C2}";
            this.lineTotalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.047480583190918D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.lineTotalTextBox.Name = "lineTotalTextBox";
            this.lineTotalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2202754020690918D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.lineTotalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.lineTotalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.lineTotalTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.lineTotalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.lineTotalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.lineTotalTextBox.Value = "=(Fields.[Freight] * Fields.[Freight])";
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.19685061275959015D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageFooterTextBox});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // pageFooterTextBox
            // 
            this.pageFooterTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00019709268235601485D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pageFooterTextBox.Name = "pageFooterTextBox";
            this.pageFooterTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.2594490051269531D), Telerik.Reporting.Drawing.Unit.Inch(0.19681096076965332D));
            this.pageFooterTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.pageFooterTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.pageFooterTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.pageFooterTextBox.Value = "THANK YOU FOR YOUR BUSINESS!";
            // 
            // reportHeaderSection
            // 
            this.reportHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20746493339538574D);
            this.reportHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.CompanyInfoPanel});
            this.reportHeaderSection.Name = "reportHeaderSection";
            this.reportHeaderSection.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.19685038924217224D);
            // 
            // CompanyInfoPanel
            // 
            this.CompanyInfoPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.companyNameTextBox});
            this.CompanyInfoPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3853931427001953D), Telerik.Reporting.Drawing.Unit.Inch(0.010377724654972553D));
            this.CompanyInfoPanel.Name = "CompanyInfoPanel";
            this.CompanyInfoPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8742527961730957D), Telerik.Reporting.Drawing.Unit.Inch(0.19708719849586487D));
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8742527961730957D), Telerik.Reporting.Drawing.Unit.Inch(0.19685037434101105D));
            this.companyNameTextBox.Style.Font.Bold = true;
            this.companyNameTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.companyNameTextBox.Value = "=Fields.[CustomerID]";
            // 
            // groupHeaderSection
            // 
            this.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D);
            this.groupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemsHeaderPanel});
            this.groupHeaderSection.Name = "groupHeaderSection";
            this.groupHeaderSection.PrintOnEveryPage = true;
            this.groupHeaderSection.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Inch(0.19685038924217224D);
            // 
            // itemsHeaderPanel
            // 
            this.itemsHeaderPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.ItemNrHeaderTextBox,
            this.descriptionHeaderTextBox,
            this.qtyHeaderTextBox,
            this.unitPriceHeaderTextBox,
            this.lineTotalHeaderTextBox});
            this.itemsHeaderPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.itemsHeaderPanel.Name = "itemsHeaderPanel";
            this.itemsHeaderPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.2677164077758789D), Telerik.Reporting.Drawing.Unit.Inch(0.23610192537307739D));
            this.itemsHeaderPanel.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.itemsHeaderPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemsHeaderPanel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // ItemNrHeaderTextBox
            // 
            this.ItemNrHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.00019709266780409962D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.ItemNrHeaderTextBox.Name = "ItemNrHeaderTextBox";
            this.ItemNrHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1021651029586792D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.ItemNrHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.ItemNrHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.ItemNrHeaderTextBox.Style.Font.Bold = true;
            this.ItemNrHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.ItemNrHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.ItemNrHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.ItemNrHeaderTextBox.Value = "No";
            // 
            // descriptionHeaderTextBox
            // 
            this.descriptionHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1024409532546997D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.descriptionHeaderTextBox.Name = "descriptionHeaderTextBox";
            this.descriptionHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1496849060058594D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.descriptionHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.descriptionHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.descriptionHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.descriptionHeaderTextBox.Style.Font.Bold = true;
            this.descriptionHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.descriptionHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.descriptionHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.descriptionHeaderTextBox.Value = "DESCRIPTION";
            // 
            // qtyHeaderTextBox
            // 
            this.qtyHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.2522046566009521D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.qtyHeaderTextBox.Name = "qtyHeaderTextBox";
            this.qtyHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.566693127155304D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.qtyHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.qtyHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.qtyHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.qtyHeaderTextBox.Style.Font.Bold = true;
            this.qtyHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.qtyHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.qtyHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.qtyHeaderTextBox.Value = "QTY";
            // 
            // unitPriceHeaderTextBox
            // 
            this.unitPriceHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.818976879119873D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.unitPriceHeaderTextBox.Name = "unitPriceHeaderTextBox";
            this.unitPriceHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2202754020690918D), Telerik.Reporting.Drawing.Unit.Inch(0.23610194027423859D));
            this.unitPriceHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.unitPriceHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.unitPriceHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.unitPriceHeaderTextBox.Style.Font.Bold = true;
            this.unitPriceHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.unitPriceHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.unitPriceHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.unitPriceHeaderTextBox.Value = "UNIT PRICE";
            // 
            // lineTotalHeaderTextBox
            // 
            this.lineTotalHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.047480583190918D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.lineTotalHeaderTextBox.Name = "lineTotalHeaderTextBox";
            this.lineTotalHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2204724550247192D), Telerik.Reporting.Drawing.Unit.Inch(0.23610192537307739D));
            this.lineTotalHeaderTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.lineTotalHeaderTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.lineTotalHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.lineTotalHeaderTextBox.Style.Font.Bold = true;
            this.lineTotalHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.lineTotalHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.lineTotalHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.lineTotalHeaderTextBox.Value = "LINE TOTAL";
            // 
            // groupFooterSection
            // 
            this.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.70866191387176514D);
            this.groupFooterSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subTotalPanel,
            this.totalPanel});
            this.groupFooterSection.Name = "groupFooterSection";
            this.groupFooterSection.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.groupFooterSection.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // subTotalPanel
            // 
            this.subTotalPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subTotalLabelTextBox,
            this.subTotalTextBox});
            this.subTotalPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.subTotalPanel.Name = "subTotalPanel";
            this.subTotalPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.2677164077758789D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.subTotalPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalPanel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalPanel.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalPanel.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2D);
            // 
            // subTotalLabelTextBox
            // 
            this.subTotalLabelTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.8189773559570312D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.subTotalLabelTextBox.Name = "subTotalLabelTextBox";
            this.subTotalLabelTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2202754020690918D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.subTotalLabelTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalLabelTextBox.Style.Font.Bold = true;
            this.subTotalLabelTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.subTotalLabelTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.subTotalLabelTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalLabelTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.subTotalLabelTextBox.Value = "Sub Total";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Format = "{0:C2}";
            this.subTotalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.047480583190918D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2202754020690918D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.subTotalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalTextBox.Style.Font.Bold = true;
            this.subTotalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.subTotalTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.subTotalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.subTotalTextBox.Value = "=Sum(Fields.[Freight] * Fields.[Freight])";
            // 
            // totalPanel
            // 
            this.totalPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.totalLabelTextBox,
            this.totalTextBox});
            this.totalPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0.35433125495910645D));
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.2677164077758789D), Telerik.Reporting.Drawing.Unit.Inch(0.35433068871498108D));
            this.totalPanel.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.totalPanel.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // totalLabelTextBox
            // 
            this.totalLabelTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.818976879119873D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.totalLabelTextBox.Name = "totalLabelTextBox";
            this.totalLabelTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2202754020690918D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.totalLabelTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.totalLabelTextBox.Style.Font.Bold = true;
            this.totalLabelTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.totalLabelTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.totalLabelTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.totalLabelTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.totalLabelTextBox.Value = "TOTAL";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Format = "{0:C2}";
            this.totalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.047480583190918D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2204724550247192D), Telerik.Reporting.Drawing.Unit.Inch(0.35433071851730347D));
            this.totalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.totalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.totalTextBox.Style.Font.Bold = true;
            this.totalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.totalTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Inch(0.11811023950576782D);
            this.totalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.totalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.totalTextBox.Value = "=Sum(Fields.[Freight] * Fields.[Freight])";
            // 
            // AnotherReport
            // 
            this.Culture = new System.Globalization.CultureInfo("en-US");
            this.DataSource = this.dataSource1;
            group1.GroupFooter = this.groupFooterSection;
            group1.GroupHeader = this.groupHeaderSection;
            group1.Name = "group";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.groupHeaderSection,
            this.groupFooterSection,
            this.pageHeaderSection,
            this.detailSection1,
            this.pageFooterSection1,
            this.reportHeaderSection});
            this.Name = "Invoice1";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Inch;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(6.2677164077758789D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dataSource1;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection;
        private Telerik.Reporting.TextBox invoiceHeaderTextBox;
        private Telerik.Reporting.Panel invoiceInfoPanel;
        private Telerik.Reporting.Panel invoiceNrPanel;
        private Telerik.Reporting.TextBox invoiceNumberHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceNrTextBox;
        private Telerik.Reporting.Panel invoiceDatePanel;
        private Telerik.Reporting.TextBox invoiceDateHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceDateTextBox;
        private Telerik.Reporting.Panel invoiceTotalPanel;
        private Telerik.Reporting.TextBox invoiceTotalHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceTotalHeaderTextBox1;
        private Telerik.Reporting.Panel panel4;
        private Telerik.Reporting.TextBox pagesHeaderTextBox;
        private Telerik.Reporting.TextBox pagesTextBox;
        private Telerik.Reporting.PictureBox companyLogoPictureBox;
        private Telerik.Reporting.DetailSection detailSection1;
        private Telerik.Reporting.TextBox itemNrTextBox;
        private Telerik.Reporting.TextBox itemDescriptionTextBox;
        private Telerik.Reporting.TextBox qtyTextBox;
        private Telerik.Reporting.TextBox unitPriceTextBox;
        private Telerik.Reporting.TextBox lineTotalTextBox;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox pageFooterTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection;
        private Telerik.Reporting.Panel CompanyInfoPanel;
        private Telerik.Reporting.TextBox companyNameTextBox;
        private Telerik.Reporting.GroupHeaderSection groupHeaderSection;
        private Telerik.Reporting.Panel itemsHeaderPanel;
        private Telerik.Reporting.TextBox ItemNrHeaderTextBox;
        private Telerik.Reporting.TextBox descriptionHeaderTextBox;
        private Telerik.Reporting.TextBox qtyHeaderTextBox;
        private Telerik.Reporting.TextBox unitPriceHeaderTextBox;
        private Telerik.Reporting.TextBox lineTotalHeaderTextBox;
        private Telerik.Reporting.GroupFooterSection groupFooterSection;
        private Telerik.Reporting.Panel subTotalPanel;
        private Telerik.Reporting.TextBox subTotalLabelTextBox;
        private Telerik.Reporting.TextBox subTotalTextBox;
        private Telerik.Reporting.Panel totalPanel;
        private Telerik.Reporting.TextBox totalLabelTextBox;
        private Telerik.Reporting.TextBox totalTextBox;

    }
}