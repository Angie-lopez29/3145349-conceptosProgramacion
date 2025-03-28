using system;
class Program{
    static void main(){
        int n;
        Console.WriteLine("Ingrese un número entero:");
        n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0){
            Console.WriteLine("El número es par.");
        } else {
            Console.WriteLine("El número es impar.");
        }
        Console.WriteLine("Fin del programa.");
        
    }
}