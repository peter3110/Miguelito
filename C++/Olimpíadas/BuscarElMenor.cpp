#include <iostream>
using namespace std;

int main(){
	int n, i, a[100], pos = 0;
	cout << "Ingrese una cantidad de numeros a comparar:\t";
	cin >> i;
	while(i > 1 && n < i)
	{
		cout << "Ingrese un numero:\t";
		cin >> a[n];
		n++;
	}
	while(a[n] >= a[n+pos])
	{
		a[n+pos] = a[0];
		pos++;
	}
	cout << "El menor numero es:\t" << a[0];
	system("pause");
}
