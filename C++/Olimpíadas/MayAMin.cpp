#include <iostream>
#include <string>
using namespace std;

int main()
{
	while(true)
	{
		string word;
		cin >> word;
		int largo = word.length();
		for(int i = 0;i < largo;i++)
		{
			if(word[i]>= 'A' && word[i] <= 'Z')
			{
				word[i] = word[i]+32;
			}
		}
		cout << word << endl;
	}
	return 0;
}
