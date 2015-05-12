#include <iostream>
#include <time.h>
#include <cstdlib>
#include <assert.h>
using namespace std;

int main(){
    int n, a, max;
    srand(time (NULL));
    
    INGRESARNUMERO:;
    cout << "Ingresa un numero del 1 al 100:\t";
    cin >> max;
    n = rand()%max;
    if(max > 1 && max <= 100)
    {
        cout << "Ingrese un numero que cree cercano:\t";
        cin >> a;
        while(a != n)
        {
				assert( 1 < a && a <= 100);
                if(a<n)
                {
                     cout << "El numero es mas grande, intentalo denuevo:\t";
                     cin >> a;
                }
                else if(a>n)
                {
                     cout << "El numero es mas chico, intentalo denuevo:\t";
                     cin >> a;
                }
        }
        if(a == n)
        {
             cout << "Bien!! El numero que ingresaste es igual al numero generado, este era:\t" << n << endl;
        }
    } else {
		cout << "Esta ingresando un número no permitido" << endl;
		goto INGRESARNUMERO;
	}      

}
