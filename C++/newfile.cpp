#include <iostream>
#include <time.h>
#include <cstdlib>
using namespace std;

int main(){
	srand(time(NULL));
	int n;
	cout << "Ingrese la cantidad de numeros de su arreglo:\t";
	cin >> n;
	int a[n], b[n]; char c[n];
	for(int i=0;i < n;i++){
		a[i] = i;
		b[i] = rand() % 10 + 1;
		c[i] = 97 + (rand()%25);
	}	
	 
	//~ Output

	for(int i = 0; i < n; i++){cout << a[i] << " ";} cout << endl;
	for(int i = 0;i < n; i++){cout << b[i] << " ";} cout << endl;
	for(int i = 0;i < n; i++){cout << c[i] << " ";};
}
