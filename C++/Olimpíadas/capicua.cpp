#include <iostream>
#include <string>
using namespace std;

int main()
{
	while(true)
	{
		string palabra;
		bool capicua = true;
		int i, j;
		
		cin >> palabra;
		i = 0;
		j = (palabra.length() -1);
		
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
		  cout << "Capicua" << endl;
		}
		else 
		{
		  cout << "No capicua" << endl;
		}
	}
	return 0;
}
