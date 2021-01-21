#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc,char *argv[])
{
    float reais = atof(argv[1]);
    float covertedValue;
    float DOLAR_VALUE = 5.36;
    
    covertedValue = DOLAR_VALUE * reais;
    
    printf("%f", covertedValue);
    
    return 0;
}
