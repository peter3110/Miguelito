#include <iostream>
#include <string>
using namespace std;

int main(){
	
	string palabra;
	int rango = 0;
	cout << "Ingrese una palabra:\t";
	cin >> palabra;
	palabra[palabra.length()-1];
	if(palabra.length() >= 0)
	{
		while(palabra[rango] = palabra[palabra.length()])
		{
			rango++;
			palabra.length()-1;
		}
		cout << "capicua" << endl;
	}
	cout << "no capicua" << endl;
}
