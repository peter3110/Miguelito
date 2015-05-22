#include <iostream>
#include <string>
using namespace std;

int main()
{
	while(true)
	{
		string palabra;
		bool capicua = true;
		int i, j, largo;
		
		cout << "Ingrese una palabra:\t";
		cin >> palabra;
		i = 0;
		j = (palabra.length() -1);
		
		largo = palabra.length();
		for(int i = 0;i < largo;i++)
		{
			if(palabra[i]>= 'A' && palabra[i] <= 'Z')
			{
				palabra[i] = palabra[i]+32;
			}
		}
		cout << "Palabra en minuscula:\t" << palabra << endl;	
		while (i <= j)
		{
			if( palabra[i] != palabra[j])
			{
				capicua = false;
			}
			i++;
			j--;
		}
		if(capicua == true)
		{
		  cout << "Es capicua?: Si" << endl;
		}
		else 
		{
		  cout << "Es capicua?: No" << endl;
		}
	}
	return 0;
}
