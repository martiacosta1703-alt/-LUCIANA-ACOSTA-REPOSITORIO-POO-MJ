

using DemoOpenClosePrinciple;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3= new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;

Rectangle rectangle1 = new Rectangle();
rectangle1.Base = 6; 
rectangle1.Altura = 3;

Rectangle rectangle2 = new Rectangle();
rectangle2.Base = 4; 
rectangle2.Altura = 5;

Rectangle rectangle3 = new Rectangle();
rectangle3.Base = 2;
rectangle3.Altura = 3;

Rhombus rhombus1 = new Rhombus(); 
rhombus1.DiagonalMayor = 8; 
rhombus1.DiagonalMenor = 4;

Rhombus rhombus2 = new Rhombus(); 
rhombus2.DiagonalMayor = 12; 
rhombus2.DiagonalMenor = 6;

Rhombus rhombus3 = new Rhombus();
rhombus3.DiagonalMayor = 10;
rhombus3.DiagonalMenor = 5;

Parallelogram parallelogram1 = new Parallelogram();
parallelogram1.Base = 6;
parallelogram1.Hight = 4;

Parallelogram parallelogram2 = new Parallelogram();
parallelogram2.Base = 2;
parallelogram2.Hight = 3;

Parallelogram parallelogram3 = new Parallelogram();
parallelogram3.Base = 6;
parallelogram3.Hight = 9;




List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
shapes.Add(rectangle1);
shapes.Add(rectangle2);
shapes.Add(rectangle3);
shapes.Add(rhombus1);
shapes.Add(rhombus2);
shapes.Add(rhombus3);
shapes.Add(parallelogram1);
shapes.Add(parallelogram2);
shapes.Add(parallelogram3);



var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");