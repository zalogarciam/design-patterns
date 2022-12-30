﻿// Coupling: how much a class is decoupled or depends on another class. Interfaces helps

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

var canvas = new Canvas();
canvas.SetCurrentTool(new SelectionTool());
canvas.MouseDown();
canvas.MouseUp();
canvas.SetCurrentTool(new BrushTool());
canvas.MouseDown();
canvas.MouseUp();