//Adam Khan, azk7ad
#include <string>
class Solution {
public:
    string defangIPaddr(string address) {
        string ns = "";
        
        for(int i=0; i<address.size(); i++){
            
            if(address[i] == '.'){
                ns.append("[.]");
            }
            else{
                ns = ns  + address[i];
            }
        }
        return ns;
    }
}
