using AngouriMath.Extensions;
using UnitsOfMeasure;
using static UnitsOfMeasure.UoM;

Console.WriteLine($"Naive case\n{new string('-', 20)}");
var distance = 5f.Meters();
Console.WriteLine($"Distance: {distance}");
//var time = 4f.Seconds();
//Console.WriteLine($"Time: {time}");

////DIVISION
//var speed = distance.Divide(time);
//Console.WriteLine($"Speed: {speed}");

////MULTIPLICATION
//var area = distance.Multiply(distance);
//Console.WriteLine($"Area: {area}");

////ADDITION
//var distance1 = distance.Add(2f.Centimeters());
//Console.WriteLine($"Distance 1: {distance1}");

////SUBSTRACTION
//var distance2 = distance.Subtract(2f.Centimeters());
//Console.WriteLine($"Distance 2: {distance2}");



//MULTIPLICATION of two different units
//var distance = 5f.Meters();

SquareMeter<float> area = distance.Multiply(distance); // 25 m^2
Console.WriteLine($"Area: {area}");


var volume = distance.Multiply(distance).Multiply(distance); // 125 m^3
Console.WriteLine($"volume: {volume}");


var unknownUnit = distance.Add(distance); // 10 m
var unknownUnit2 = unknownUnit.Multiply(2f.Kilograms()); // 20 kg*m

var unknownUnit3 = unknownUnit.Multiply(2f.Kilograms()).Divide(2f.Kilograms()); // 10 (m*kg) / kg
var unknownUnit4 = unknownUnit.Multiply(2f.Kilograms()).Divide(2f.Kilograms()); // 10 (m*kg) / kg

var unknownUnit9 = unknownUnit3.Add(unknownUnit4);
var unknownUnit11 = unknownUnit.Multiply(2f.Kilograms()).Divide(2f.Kilograms()).Add(unknownUnit.Multiply(2f.Kilograms()).Divide(2f.Kilograms()));
//var unknownUnit9 = unknownUnit3.Add(unknownUnit2.Divide(unknownUnit4));

Console.WriteLine($"UnknownUnit  : {unknownUnit}");
Console.WriteLine($"UnknownUnit2 : {unknownUnit2}");
Console.WriteLine($"UnknownUnit3 : {unknownUnit3}");
Console.WriteLine($"UnknownUnit4 : {unknownUnit4}");
Console.WriteLine($"UnknownUnit9 : {unknownUnit9}");
Console.WriteLine($"UnknownUnit11: {unknownUnit11}");



var distance77 = 5f.Meters();
Unit<Meter<float>, Meter<float>, float> knownDistance = distance77;
var unknownUnit77 = knownDistance.Add(knownDistance); // 10 m
Console.WriteLine($"UnknownUnit77: {unknownUnit77}");

var distance777 = 5f.Meters();
var unknownUnit777 = distance777.Add(distance777); // 10 m
//Kilometer<float> kilometer = unknownUnit777.To<Kilometer<float>>();


Console.WriteLine($"\nLinear conversions\n{new string('-', 20)}");

var anotherDistance = UoM.Kilometers(0.3f);
Console.WriteLine($"Another distance: {anotherDistance}");
Console.WriteLine($"Total distance: {distance.Add(anotherDistance)}");

Console.WriteLine($"\nMore complex conversions\n{new string('-', 20)}");

var speed1 = 20.0.Meters().Divide(1.0.Seconds());
Console.WriteLine($"Speed 1: {speed1}");
var speed2 = 5.0.Kilometers().Divide(1.0.Minutes());
Console.WriteLine($"Speed 2: {speed2}");
var added = speed1.Add(speed2);
Console.WriteLine($"Their sum: {added}");

var area1 = 0.3.Kilometers().Square();
var area2 = 0.2.Miles().Square();
Console.WriteLine($"Area 1: {area1}");
Console.WriteLine($"Area 2: {area2}");
Console.WriteLine($"Total area: {area1.Add(area2)}");

//Console.WriteLine($"\nSymbolic algebra formulas\n{new string('-', 20)}");

//var mass1 = "m_1".ToEntity().Kilograms();
//var mass2 = "m_2".ToEntity().Kilograms();
//var r = "(R - theta)".ToEntity().Meters();

//Console.WriteLine($"Mass1: {mass1}");
//Console.WriteLine($"Mass2: {mass2}");
//Console.WriteLine($"Radius: {r}");

//var formula = mass1.Add(mass2).Divide(r.Square());
//var formula = mass1 + mass2 / r.Square();

//Console.WriteLine($"Gravity force or something: {formula}");