# include <iostream>
# include <assert.h>
# include <string>
# include <cstdlib>
using namespace std;

#define CANT_NUMEROS 10
#define CANT_PALOS 4
#define NUMEROS "1", "2", "3", "4", "5", "6", "7", "10", "11", "12"
#define PALOS "Espada", "Oro", "Copa", "Basto"

int main() {
  
  string cartas[CANT_NUMEROS * CANT_PALOS];
  for(int i=0; i<CANT_NUMEROS; i++) {
	for(int j=0; j<CANT_PALOS; j++) {
		cartas[i+j] = numeros[i] + palos[j]; 
	}
  }
  
  int cant_jugadores;
  while(true) {
	 cout << "Introduzca cantidad de jugadores" << endl;
	 cin >> cant_jugadores; 
	 assert(cant_jugadores == 2 || cant_jugadores == 4);	// sino es 2 o 4 finaliza, con error
	 
	 string numeros[CANT_NUMEROS] = {NUMEROS};
	 string palos[4]    = {PALOS};
  
	 srand(time(NULL));
	 for(int jug=0; jug < cant_jugadores; jug++) {
		
	 }
	 
	 
  }
  
  return 0;
}
