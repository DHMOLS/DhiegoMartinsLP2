#include <stdio.h>
int main()

{
	int n, fat;

	scanf("%d",&n);

	for(fat = 1; n > 0; n = n-1)
	{
		fat = fat * n;
	}

	printf("\n%d",fat);

	return 0;

} 