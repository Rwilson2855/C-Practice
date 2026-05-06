const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int openingPosition = input.IndexOf("<span>");

int closingPosition = input.IndexOf("</span>");
openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine("Quantity: "+ input.Substring(openingPosition, length));


Console.WriteLine(quantity);
Console.WriteLine(output);