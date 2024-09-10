using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parnas.Infrastructure.Migrations
{
    public partial class Mig_Init_Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Lighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterfaceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Microphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Input = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutPut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AntiGhosting = table.Column<bool>(type: "bit", nullable: false),
                    Sensor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Inch3_5DriveBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inch2_5DriveBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSizeOfCoolerCeilingPanel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSizeOfCoolerFrontPanel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxSizeOfCoolerBackPanel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumCPUCoolerHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumLengthOfGraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberofPowerSuppliesThatCanBeInstalled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerSupplyInstallationLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFansThatCanBeInstalledInCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFanInstalledInCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOf120mmInstallableFans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfInstalledFansIs140mm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFansThatCanBeInstalledonTheBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFansThatCanBeInstalledInTheFront = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfFansThatCanBeInstalledinTheCeiling = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberofUSBPortsIs3Cases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseUSBType_CPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaseFanSpeedController = table.Column<bool>(type: "bit", nullable: false),
                    FancaseLightingController = table.Column<bool>(type: "bit", nullable: false),
                    Lighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MicrophoneInput = table.Column<bool>(type: "bit", nullable: false),
                    HeadPhoneOutPut = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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
                name: "Coolings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IntelSocketSupport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AMDSocketSupport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfProccesorBlock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlockLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FanConnection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfCoolingFans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfCoolingFan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingFanRotationSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FanLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PumpRotationSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumAirFlow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadiatorMaterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadiatorDimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingPipeLenght = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Generation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoreCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StringCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoreE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoreP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseFerequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoostFerequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CachLevel2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CachLevel3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUMemoryTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDDFerequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUMaxHdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUMonitorCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCIExpressCPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicProccesor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicProccesorModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicProccesorFerequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerCounsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Packaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FanCases",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FanCaseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FanCaseUsageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FanCaseController = table.Column<bool>(type: "bit", nullable: false),
                    CaseFanSpeedController = table.Column<bool>(type: "bit", nullable: false),
                    CaseFanNoiseLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatiotionSpeedOfTheCaseFan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FanCaseLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumCaseAirFlow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FanCaseLightingController = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FanCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gamings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherBoard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Graphic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hdd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeepCool = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Case = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraphicCards",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GraphicCardModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPUManuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicCardProccesorGeneration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfGraphicCardFans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemorySize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemorySpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseFerequencyOfTheGraphicsCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoostFerequensyOfTheGraphicsCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InterfaceBandWidth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CudaCore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PciExpressGeneration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectXInterface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenGLInterface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDCPSupport = table.Column<bool>(type: "bit", nullable: false),
                    FullHdSupport = table.Column<bool>(type: "bit", nullable: false),
                    K4Support = table.Column<bool>(type: "bit", nullable: false),
                    K8Support = table.Column<bool>(type: "bit", nullable: false),
                    MaximumResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportedDisplay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HdmiOutPutOfTheGraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayPortOutputOfTheGraphicCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphicsCardCooler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HDDs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheAppearanceOfTheHardDrive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardDrivePort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RotationSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardDiskCachMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonitorUserClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PannelType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackLight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusContrast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayAspectRatio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScreenResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisualAngle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonitorTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HdmiImagePort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayImagePort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsbPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VesaSupport = table.Column<bool>(type: "bit", nullable: false),
                    RotationCapability = table.Column<bool>(type: "bit", nullable: false),
                    PowerConsumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotherBoards",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chipset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppearanceOfTheMotherBoard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProccesorSocket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportedProccesor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherBoardMemoryTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemorySlot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Configuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaximumMemorySize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XmpSupport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPUPowerConnector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCIExperssX16Slot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCIExperssX16Generation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M2Slot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSataPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RaidSupport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherBoardDisplayPortOutput = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HdmiOutputOfTheMotherBoard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoundChipset = table.Column<bool>(type: "bit", nullable: false),
                    Bluetooth = table.Column<bool>(type: "bit", nullable: false),
                    BluetoothVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotherBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Powers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PowerSupplyConnectionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NominalPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ATX3Standard = table.Column<bool>(type: "bit", nullable: false),
                    PowerSupplyFanLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerSupplyFanSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Current33V = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plus5VCurrent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First12Current = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    v12VoltCurrent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Current5VSBV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin24Connection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    P4P4PinConnection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PinPcieConnection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PinConnector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PinSataConnector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EighteenPlusCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProtectionStandards = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Powers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumberOfPin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamCooler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RomeLighting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfRamMemory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumeOfEachModules = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalMemorySize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ferequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSDs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SSDAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSDInterface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSDMemoryTechnology = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSDPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadingSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WritingSpeed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longevity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dimensions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Categories");

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
        }
    }
}
