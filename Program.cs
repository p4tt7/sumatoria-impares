int n = int.Parse(Console.ReadLine());
int contador = 1;
int suma=0;
while (contador<n*2){

    if(contador%2!=0){
        suma+=contador;
        contador++;
    }
    else{
        contador++;
    }
}
Console.WriteLine(suma); 