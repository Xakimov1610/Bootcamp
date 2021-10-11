//         int n=s.size(),X=0,count=0;
        
//         for(int i=0; i<n; i++){
//             if(s[i] == 'X') X++;
            
//             if(s[i] == 'O'){
//                 if(X!=0) X++;
//             }
            
//             if(X==3){
//                 X=0;
//                 count++;
//             }
//         }
        
//         if(X>0) count++;
//         return count;
//     }
// }

using System;

namespace bootcamp.Solutions
{
    class Lab7
    {
        public void TryProblem()
        {
            string str = "GeeksforGeeks";
          
            // using Chars[Int32] & Length property
            for (int i = 0; i <= str.Length - 1; i++)
                Console.Write("{0} ", str[i]);
        }
    }
}