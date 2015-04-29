#include <iostream>
using namespace std;

int main()
{
	int i = 0, a, b[100], suma= 0;
	cout << "Ingrese la cantidad de numeros a sumar:" << endl;
	cin >> a;
	while(a > 0 && i < a)
	{
		cout << "Ingrese un numero:" << endl;
		cin >> b[i];
		suma = suma + b[i];
		i++;	
	}
	cout << "La suma de todos los numero es: " << suma << endl;
	return 0;
}
