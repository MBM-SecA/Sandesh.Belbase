namespaceAllAboutClasses
{
publicclassCountry
    {
//default constructor
publicstringName{get;set;}
publicintPopulation { get; set; }
publicreadonlydouble AREA=43443.45; 
publicstaticreadonlybool IsOnEarth;
publicCountry()
        {
 
        }
// Parameterized Constructor
publicCountry(stringname)
        {
Name =name;
        }
 
publicCountry(stringname,intpopulation, doublearea)
        {
Name =name;
Population = population;
AREA = area;
        }
//static constructor
staticCountry()
        {
IsOnEarth=true;
        }//executes only one time 
 
    }
publicclassDemo
    {
voidDoSomething()
        {
Countrycountry1 = newCountry();
Countrycoountry2 = newCountry("Nepal");
 
        }
    }
}

usingSystem;
 
publicinterfaceIshapeWithSides//interface for multiple inheritance
{
doubleGetDiagonal();
}
publicabstractclassShape
{
publicabstractdoubleGetArea();

publicabstractdoubleGetCircumference();

publicvirtualvoidDisplay()
    {
Console.WriteLine($"Displaying result for shape");
    }
 
}
 
publicclassRectangle: Shape,IshapeWithSides
{
publicRectangle(doublelength,doublebreadth)
    {
Length=length;
Breadth=breadth;
    }
publicdoubleLength { get; set; }
publicdoubleBreadth { get; set; }
publicoverridedoubleGetArea()=> Length*Breadth;
publicoverridedoubleGetCircumference()=> 2*(Length + Breadth);
publicoverridevoidDisplay()
    {
Console.WriteLine($"Displaying result for Rectangle of side [{Length} X {Breadth}]");
Console.WriteLine($"Area:{this.GetArea()}");
Console.WriteLine($"Perimeter:{this.GetCircumference()}");
Console.WriteLine($"Diagonal:{this.GetDiagonal()}");

    }
 
publicdoubleGetDiagonal() => Math.Sqrt(Length*Length + Breadth*Breadth);
}
publicclassSquare: Rectangle
{
publicSquare(doubleside) : base(side,side)
    {
 
    }        

}
 
publicclassCircle: Shape
{
publicCircle(doubleradius)
    {
Radius = radius;
    }
publicdoubleRadius { get; set; }
publicoverridedoubleGetArea()=> Math.PI*Radius*Radius;
publicoverridedoubleGetCircumference()=> 2*Math.PI*Radius;
publicoverridevoidDisplay()
    {
Console.WriteLine($"Displaying result for Circle of Radius {Radius}");
Console.WriteLine($"Area:{this.GetArea()}");
Console.WriteLine($"Perimeter:{this.GetCircumference()}");

    }
}

