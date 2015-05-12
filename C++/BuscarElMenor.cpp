#include <iostream>
using namespace std;

int main(){
	while(true) {
		int n, i = 0, a[100], pos = 1;
		cout << "Ingrese una cantidad de numeros a comparar:\t";
		cin >> n;
		while(i < n)
		{
			cout << "Ingrese un numero:\t";
			cin >> a[i];
			i++;
		}
		// a[pos] = a[1]
		// a = a0|a1|a2|a3|...|an
		while(pos < n)
		{
			if(a[0] >= a[pos]) { 
				a[0] = a[pos]; 
			}
			pos++;
		}
		cout << " " << endl;
		cout << "El menor numero es:\t" << a[0] << endl;
	}
}

/* FUNCIONA - LTA */
