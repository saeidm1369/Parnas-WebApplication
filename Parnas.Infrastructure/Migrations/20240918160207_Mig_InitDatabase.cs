using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class Mig_InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectionPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterfaceType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Microphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutPut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AntiGhosting = table.Column<bool>(type: "bit", nullable: false),
                    Sensor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accessories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inch3_5DriveBay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inch2_5DriveBay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxSizeOfCoolerCeilingPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxSizeOfCoolerFrontPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxSizeOfCoolerBackPanel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumCPUCoolerHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumLengthOfGraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofPowerSuppliesThatCanBeInstalled = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerSupplyInstallationLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFansThatCanBeInstalledInCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFanInstalledInCase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOf120mmInstallableFans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfInstalledFansIs140mm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFansThatCanBeInstalledonTheBack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFansThatCanBeInstalledInTheFront = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfFansThatCanBeInstalledinTheCeiling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofUSBPortsIs3Cases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseUSBType_CPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseFanSpeedController = table.Column<bool>(type: "bit", nullable: false),
                    FancaseLightingController = table.Column<bool>(type: "bit", nullable: false),
                    Lighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MicrophoneInput = table.Column<bool>(type: "bit", nullable: false),
                    HeadPhoneOutPut = table.Column<bool>(type: "bit", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cases_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coolings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntelSocketSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMDSocketSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfProccesorBlock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlockLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfCoolingFans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfCoolingFan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingFanRotationSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PumpRotationSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumAirFlow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadiatorMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadiatorDimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingPipeLenght = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coolings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Generation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoreCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StringCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoreE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoreP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseFerequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoostFerequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CachLevel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CachLevel3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPUMemoryTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HDDFerequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPUMaxHdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPUMonitorCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCIExpressCPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicProccesor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicProccesorModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicProccesorFerequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerCounsumption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packaging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPUs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FanCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FanCaseType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanCaseUsageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanCaseController = table.Column<bool>(type: "bit", nullable: false),
                    CaseFanSpeedController = table.Column<bool>(type: "bit", nullable: false),
                    CaseFanNoiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RatiotionSpeedOfTheCaseFan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FanCaseLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumCaseAirFlow = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LightingControllerFanCase = table.Column<bool>(type: "bit", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FanCases_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gamings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherBoard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Graphic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepCool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Case = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gamings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GraphicCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GraphicCardModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPUManuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicCardProccesorGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfGraphicCardFans = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemorySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemorySpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseFerequencyOfTheGraphicsCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoostFerequensyOfTheGraphicsCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InterfaceBandWidth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CudaCore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PciExpressGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectXInterface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenGLInterface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HDCPSupport = table.Column<bool>(type: "bit", nullable: false),
                    FullHdSupport = table.Column<bool>(type: "bit", nullable: false),
                    K4Support = table.Column<bool>(type: "bit", nullable: false),
                    K8Support = table.Column<bool>(type: "bit", nullable: false),
                    MaximumResolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportedDisplay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HdmiOutPutOfTheGraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayPortOutputOfTheGraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicsCardCooler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedPower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GraphicCards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HDDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheAppearanceOfTheHardDrive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardDrivePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RotationSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardDiskCachMemory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDDs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonitorUserClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreenSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PannelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackLight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusContrast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayAspectRatio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreenResolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisualAngle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonitorTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateRate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HdmiImagePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayImagePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsbPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VesaSupport = table.Column<bool>(type: "bit", nullable: false),
                    RotationCapability = table.Column<bool>(type: "bit", nullable: false),
                    PowerConsumption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppearanceOfTheMotherBoard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProccesorSocket = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupportedProccesor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherBoardMemoryTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemorySlot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Configuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumMemorySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XmpSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPUPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCIExperssX16Slot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PCIExperssX16Generation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    M2Slot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfSataPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaidSupport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherBoardDisplayPortOutput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HdmiOutputOfTheMotherBoard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoundChipset = table.Column<bool>(type: "bit", nullable: false),
                    Bluetooth = table.Column<bool>(type: "bit", nullable: false),
                    BluetoothVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotherBoards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PowerSupplyConnectionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NominalPower = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATX3Standard = table.Column<bool>(type: "bit", nullable: false),
                    PowerSupplyFanLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PowerSupplyFanSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Current33V = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plus5VCurrent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First12Current = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    v12VoltCurrent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Current5VSBV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pin24Connection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P4P4PinConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinPcieConnection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PinSataConnector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EighteenPlusCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtectionStandards = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Powers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfPin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RamCooler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RomeLighting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfRamMemory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolumeOfEachModules = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalMemorySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ferequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rams_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SSDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SSDAppearance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSDInterface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSDMemoryTechnology = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSDPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReadingSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WritingSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longevity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SSDs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accessories_CategoryId",
                table: "Accessories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_CategoryId",
                table: "Cases",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Coolings_CategoryId",
                table: "Coolings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUs_CategoryId",
                table: "CPUs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FanCases_CategoryId",
                table: "FanCases",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Gamings_CategoryId",
                table: "Gamings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GraphicCards_CategoryId",
                table: "GraphicCards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HDDs_CategoryId",
                table: "HDDs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_CategoryId",
                table: "Monitors",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MotherBoards_CategoryId",
                table: "MotherBoards",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Powers_CategoryId",
                table: "Powers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Rams_CategoryId",
                table: "Rams",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SSDs_CategoryId",
                table: "SSDs",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Coolings");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "FanCases");

            migrationBuilder.DropTable(
                name: "Gamings");

            migrationBuilder.DropTable(
                name: "GraphicCards");

            migrationBuilder.DropTable(
                name: "HDDs");

            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "MotherBoards");

            migrationBuilder.DropTable(
                name: "Powers");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "SSDs");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
