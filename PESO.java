Peso
{

	class program
	{

   const double Gravedad = 9.8;
  static vold main(string[]args)
{
  double peso, masa;

  console.Write("Ingrese la masa");
  masa = double.Parse(Console.ReadLine());

  peso = masa * Gravedad;
  Console.WriteLine();

  Console.WriteLine("peso: " + peso + " Newton");

  Console.ReadKey();
}

}

}