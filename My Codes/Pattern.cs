using System;

public class HelloWorld
{
    void pattern()
    {
        int n = 6;
        
        int h = n;
        for(int i =0; i < n; i++)
        {
        	int k = n;
            for(int l=0; l<i+1;l++)
            {
            	Console.Write(" ");
                
                k=k-1;
            }
            k++;
            for(int j=i;j<n;j++)
            {
            	
                Console.Write(k);	
                k = k-1;
            }
            
            h=h-1;
           Console.WriteLine(" ");
           
        }
    }    
}