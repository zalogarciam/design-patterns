// Coupling: how much a class is decoupled or depends on another class. Interfaces helps --> loosely coupled applications

// User user = new User("John Smith");
// user.SayHello();

// Interfaces: a contract that specifies the capabilities that a class should provide

// TaxCalculator calculator = GetCalculator();
// calculator.CalculateTax();

// static TaxCalculator GetCalculator()
// {
//     return new TaxCalculator2022();
// }

// Encapsulation: do not allow other classes like the main class to change the state of an object directly

// var account = new Account();
// // account.balance = -1;
// account.Deposit(10);
// account.Withdraw(5);
// Console.WriteLine(account.GetBalance());

// Abstraction: Reduce complexity by hiding unnecessary details

// var mailService = new Mail();
// mailService.SendEmail(); // Only this method insteado of 4

// Inheritance: is a a mecanism that allows us to reuse code across different classes

// TextBox
// Button
// CheckBox

// enable()
// focus()
// setPosition()

// var textBox = new TextBox();
// textBox.Enable();

// Polymorphism: Many Forms - hability of an object of take on many forms.

// DrawUIControl(new TextBox());
// DrawUIControl(new CheckBox());

// static void DrawUIControl(UIControl control)
// {
//     control.Draw();
// }

// Memento --> Single Responsability

// var editor = new Editor();
// var history = new History();

// editor.Content = "a";
// history.States.Push(editor.CreateState());

// editor.Content = "b";
// history.States.Push(editor.CreateState());

// editor.Content = "c";
// editor.Restore(history.States.Pop());
// editor.Restore(history.States.Pop());

// Console.WriteLine(editor.Content);

// var document = new Document();
// var documentHistory = new DocumentHistory();

// document.Content = "Test";
// document.FontName = "Arial";
// document.FontSize = 12;

// documentHistory.States.Push(document.CreateState());

// document.Content = "Test 2";
// document.FontName = "Arial Bold";
// document.FontSize = 14;
// documentHistory.States.Push(document.CreateState());

// document.Content = "Test 3";
// document.FontName = "Arial Italic";
// document.FontSize = 16;

// document.ShowDocument();

// document.Restore(documentHistory.States.Pop());
// document.Restore(documentHistory.States.Pop());

// document.ShowDocument();

// State -- Open Close Principle

// var canvas = new Canvas();
// canvas.SetCurrentTool(new SelectionTool());
// canvas.MouseDown();
// canvas.MouseUp();
// canvas.SetCurrentTool(new BrushTool());
// canvas.MouseDown();
// canvas.MouseUp();


// Abuse: Design smell
// Simplicity is the ultimate sophistication

// var stopWatch = new StopWatch();
// stopWatch.click();
// stopWatch.click();
// stopWatch.click();

// var travel = new TravelMode(new DrivingService());
// travel.GetDirection();
// travel.GetETA();

// Iterator -- changing the internals of an object should not affect its consumers.
// var browserHistory = new BrowserHistory<string>();
// browserHistory.Push("a");
// browserHistory.Push("b");
// browserHistory.Push("c");

// var iterator = browserHistory.CreateIterator();
// while (iterator.HasNext())
// {
//     var url = iterator.Current();
//     Console.WriteLine(url);
//     iterator.Next();
// }

// var productList = new ProductCollection();
// productList.Add(new Product(1, "A"));
// productList.Add(new Product(2, "B"));
// productList.Add(new Product(3, "C"));

// var productIterator = productList.CreateIterator();
// while (productIterator.HasNext())
// {
//     var product = productIterator.Current();
//     Console.WriteLine(product.ToString());
//     productIterator.Next();
// }

// var imageStorage = new ImageStorage();
// imageStorage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
// imageStorage.Store("a", new PngCompressor(), new BlackAndWhiteFilter());

// var chatClient = new ChatClient(new AesEncryptionAlgorithm());
// chatClient.Send("Test");

// var task = new TransferMoneyTask();
// task.Execute();

// var window = new ReportWindow();
// window.Close();

// var service = new CustomerService();
// var command = new AddCustomerCommand(service);
// var button = new Button(command);
// button.Click();

// var compositeCommand = new CompositeCommand();
// compositeCommand.Add(new ResizeCommand());
// compositeCommand.Add(new BlackAndWhiteCommand());
// compositeCommand.Execute();

// var history = new HistoryCommand();
// var document = new HtmlDocument("Hello world!");

// var boldCommand = new BoldCommand(document, history);
// boldCommand.Execute();
// Console.WriteLine(document.Content);
// // boldCommand.Unexecute();
// // Console.WriteLine(document.Content);

// var undoCommand = new UndoCommand(history);
// undoCommand.Execute();
// Console.WriteLine(document.Content);

// var videoEditor = new VideoEditor();
// var history = new HistoryCommand();

// var labelCommand = new LabelCommand("Title", videoEditor, history);
// labelCommand.Execute();
// Console.WriteLine(videoEditor.ToString());
// Console.WriteLine(history.Size());

// var contrastCommand = new ContrastCommand(1, videoEditor, history);
// contrastCommand.Execute();
// Console.WriteLine(videoEditor.ToString());
// Console.WriteLine(history.Size());

// var undoCommand = new UndoCommand(history);
// undoCommand.Execute();
// Console.WriteLine(videoEditor.ToString());
// Console.WriteLine(history.Size());

// undoCommand.Execute();
// Console.WriteLine(videoEditor.ToString());
// Console.WriteLine(history.Size());

// undoCommand.Execute();
// Console.WriteLine(videoEditor.ToString());
// Console.WriteLine(history.Size());

// var dataSource = new DataSource<int>();
// var sheet1 = new SpreadSheet<int>();
// var sheet2 = new SpreadSheet<int>();
// var chart = new Chart<int>();

// dataSource.AddObserver(sheet1);
// dataSource.AddObserver(sheet2);
// dataSource.AddObserver(chart);
// dataSource.SetN(1);

// var dataSource = new DataSource1<int>();
// var sheet1 = new SpreadSheet1<int>(dataSource);
// var sheet2 = new SpreadSheet1<int>(dataSource);
// var chart = new Chart1<int>(dataSource);

// dataSource.AddObserver(sheet1);
// dataSource.AddObserver(sheet2);
// dataSource.AddObserver(chart);
// dataSource.SetN(1);

// var stock = new Stock<StockModel>();
// var statusBar = new StatusBar<StockModel>();
// var stockListView = new StockListView<StockModel>();

// stock.AddObserver(statusBar);
// stock.AddObserver(stockListView);
// stock.SetStock(new StockModel(150, "Test"));

// Mediator

// var dialog = new MyArticuleDialogBox();
// dialog.SimulateUserInteraction();

// var dialog = new SignUpDialogBox();
// dialog.SimulateUserInteraction();

// Chain of Responsability

// var compressor = new Compressor(null);
// var logger = new Logger(compressor);
// var auth = new Authenticator(logger);
// var server = new WebServer(auth);
// server.Handle(new HttpRequest("Admin", "1234"));

// var quickBook = new QuickBookHelper(null);
// var number = new NumberHelper(quickBook);
// var excel = new ExcelHelper(number);
// var dataReader = new DataReader(excel);
// dataReader.Handle(new DataRequest("file.qbw .xls .numbers"));

// Visitor

// var document = new HtmlDocumento();
// document.Add(new HeadingNode());
// document.Add(new AnchorNode());
// document.Execute(new HighLightOperation());
// document.Execute(new PlainTextOperation());

// WavFile.read("File");

// Composite

// var group1 = new Group();
// group1.Add(new Shape()); // Square
// group1.Add(new Shape()); // Square

// var group2 = new Group();
// group2.Add(new Shape()); // Circle
// group2.Add(new Shape()); // Circle

// var group3 = new Group();
// group3.Add(group1);
// group3.Add(group2);
// group3.Render();

// var subTeam1 = new Team();
// subTeam1.add(new Truck());
// subTeam1.add(new HumanResource());
// subTeam1.add(new HumanResource());

// var subTeam2 = new Team();
// subTeam2.add(new Truck());
// subTeam2.add(new HumanResource());
// subTeam2.add(new HumanResource());

// var team = new Team();
// team.add(subTeam1);
// team.add(subTeam2);

// team.deploy();

// Other...

// Adapter

var imageView = new ImageView(new Image());
imageView.Apply(new CaramelFilter(new Caramel())); // Adapter

var emailClient = new EmailClient();
emailClient.addProvider(new GmailProvider(new GmailClient()));
emailClient.downloadEmails();
