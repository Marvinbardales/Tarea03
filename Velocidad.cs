
// Marvin Geovany Santos Bardales  cif : 2016010327
int main()
{
            float d;
            float t;
            float v;
             char c;
             
             
            
            printf("\n\n\n Introduzca distacia en KM:");
    scanf("%f",&d);
        c = getche();
	   
    if (d > 0&& d!=isalpha(c) ){
       printf(" digite el tiempo en horas:");
      
       scanf("%f",&t);
        if(t  >=0)
        v=d/t;
      
        printf("la velocidad es km/h %.2f",v);
         Sleep(2000);
      
        
    }
    
    else
    {
       printf(" dato no valido");
    }
     
     
      
         
    return 0;
}
