#include <iostream>
using namespace std;

int main(){
int num1, num2, resultado, cantidad1;
num1 = num2 = resultado = 0;
cout << "Ingrese el Primer Numero \t";
cin >> num1;
cout << "Ingrese el Segundo Numero \t";
cin >> num2;

 while (num1 > 1){
 	int potencia = 2;
 	while (num1 >= potencia){
 		potencia = potencia * 2;
 	}
 	resultado += num2 * (potencia/2);
 	cout << num2 << " * " << potencia/2 << " + ";
 	num1 -= potencia/2;
 }
 if(num1 == 1)
 	resultado += num2;
 	cout << num2<<" * "<<1<<endl;

cout <<"El resultado es: "<< resultado << endl;
system("pause");
}
