// See https://aka.ms/new-console-template for more information

using DogManager;
using myLib;

Console.WriteLine("Hello, World!");
var d = new Dogger();

var dog = Dogger.dog;
var tme = new Testme(dog);

tme.DoStackLogTest("my test");
