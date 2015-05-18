#include <iostream>
#include <time.h>
#include <cstdlib>
using namespace std;

int main(){
    int n, a, max;
    srand(time (NULL));

    cout << "Ingresa un numero del 1 al 100:\t";
    cin >> max;
    n = rand()%max;
    if(max > 1 && max <= 100)
    {
        cout << "Se ha generado un numero aleatorio entre el 1 y " << max << ":\t";
        cin >> a;
        while(a != n)
        {
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
        cout << "Bien!! El numero que ingresaste es igual al numero generado, este era:\t" << n << endl;
    } else {
		cout << "Esta ingresando un número no permitido" << endl;
	}     
    system("pause"); 
}
