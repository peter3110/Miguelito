#include <iostream>
using namespace std;

int main(){
	
	int n, u = 0, a[100], temp = 0;
	cout << "Ingrese una cantidad de numeros a comparar:\t";
	cin >> n;
	while(u < n){
		cout << "Ingrese un numero:\t";
		cin >> a[u];
		u++;
	}
	for(int j=1;j<n;j++){
		for(int i = 0; i < n-1; i++){
			if(a[i] > a[i+1]){
				temp = a[i];
				a[i] = a[i+1];
				a[i+1] = temp;
			}
		}
	}
	for(int i = 0; i < n; i++){
		
		cout << a[i] << " ";
	}
}
