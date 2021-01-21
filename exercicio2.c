#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc,char *argv[])
{
    char *value = argv[1];
    value[strcspn(value, "\n")]=0;
    int length = strlen(value);
    int aux = 0, aux1 = 0;
    char numAux = '0';

    for(int i; i < length; i++){
        aux = 0;
        for(int j = 0; j < length; j++){
            if (value[i] == value[j]){ 
                aux++;
            }
        }
        if(aux > aux1){
            aux1 = aux;
            printf("%c", value[i]);
            numAux = value[i];
        }
    }
    
    printf("%c", numAux);
    
    return 0;
}

