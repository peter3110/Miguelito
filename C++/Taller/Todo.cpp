#include <iostream>
#include <time.h>
#include <cstdlib>
using namespace std;

int main(){
    
    long num1 = 0, num2 = 0, suma = 0, punto = 0;
    srand(time(NULL));
    cout << "Apreta 'Enter' para tirar dos dados" << endl;
    system("pause");
    num1 = (rand()*10%6)+1;
    num2 = (rand()*10%6)+1;
    punto = num1 + num2;
    cout << "Sacaste:\t" << punto << endl;
    switch(punto)
    {
         case 7: case 11:
              cout << "Ganaste\t" << endl;
              break;
         case 2: case 3: case 12:
              cout << "Perdiste\t" << endl;
              break;
         default:
         system("pause");
         while(suma != punto && suma != 7)
         {
                    suma = ((rand()*10%6)+1) + ((rand()*10%6)+1);
                    cout << "Puntos:\t" << suma << endl;
                    system("pause");
         }
         if(suma == punto)
         {
             cout << "Ganaste" << endl;
         }
         else
         {
             cout << "Perdiste" << endl;
         }
         break;
    }
    system("pause");
}
