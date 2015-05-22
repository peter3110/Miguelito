#include <iostream>
#include <time.h>
using namespace std;

int main(){
    int n, a, max;
    srand(time (NULL));
    cout << "Ingresa un numero del 2 al 100000:\t";
    cin >> max;
    n = rand()%max;
    if(max > 1 && max < 100000)
    {
        cout << "Ingrese un numero que cree cercano:\t";
        cin >> a;
        while(a != n)
        {
                if(a<n)
                {
                     cout << "El numero es mas grande, intentalo denuevo:\t" << endl;
                     cin >> a;
                }
                else if(a>n)
                {
                     cout << "El numero es mas chico, intentalo denuevo:\t" << endl;
                     cin >> a;
                }
        }
        if(a = n)
        {
             cout << "Bien!! El numero que ingresaste es igual al numero generado que era:\t" << n << endl;
        }
    }      
    system("pause");
}
