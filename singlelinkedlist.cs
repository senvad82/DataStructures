using System;
namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        private node start;
        private node current;

        public SingleLinkedList(){
            start = null;
            current = null;
        }
        public void DisplayList(){
            Console.WriteLine(' ');

            node p = start;
            if (start == null){
                Console.WriteLine("List is Empty");
                return;
            }
            while(p !=null){
                Console.Write(p.info);
                Console.Write(' ');
                p = p.link;
            }
            Console.WriteLine(' ');
            Console.WriteLine(' ');
        }
        public void CreateList(int[] list){
             for(int i = 0; i < list.Length;i++ ){
                node myNode = new node(list[i]);
                if (start == null){
                    start = myNode;
                   current = myNode;
                }
                else{
                    current.link = myNode;
                    current = myNode;
                }

            }
            
        }

        public void CreateList(){
            Console.Write("Enter number of nodes:");
            var n = Convert.ToInt32(Console.ReadLine());
            node p=start;
            for(int i = 0; i < n;i++ ){
                Console.Write("Enter value:");    
                node myNode = new node(Convert.ToInt32(Console.ReadLine()));
                if (start == null){
                    start = myNode;
                   current = myNode;
                }
                else{
                    current.link = myNode;
                    current = myNode;
                }

            }
        }

        

        public void Count(){
            node p = start;
            int c = 0;
            while(p!=null){
                c = c+1;
                p = p.link;
            }
            Console.WriteLine("Total Count " + c.ToString());
        }

         public void Find(int n){
            node p = start;
            int c = -1;
            while(p!=null){
                c = c+1;
                if (p.info == n){
                    Console.WriteLine("Index :"+ c.ToString());
                    break;
                }
                p = p.link;
            }
            Console.WriteLine("Total Count " + c.ToString());
        }

        public void insertAtStart(int n){
            node newNode = new node(n);
            newNode.link = start;
            start = newNode;
            DisplayList();
        }

        public void insertAtEnd(int n){
            node newNode = new node(n);
            current.link = newNode;
            DisplayList();
        }

         public void insertAt(int n, int i){
            node newNode = new node(n);
            node p = start;
            int c = 0;
            node prevNode = start;
            while(p!=null){
                if (c == i){
                    break;
                }
                prevNode = p;
                p = p.link;
                c = c + 1;
                
            }
            prevNode.link = newNode;
            newNode.link = p;
            DisplayList();
        }

        public void DeleteNode(int n){
            node p = start;
            node prevNode=start;
            while(p!=null){
                
                if (p.info == n ){
                    
                    if (p == start){
                        start = p.link;
                    }
                    else{
                        prevNode.link = p.link;
                    }
                    
                }
                prevNode = p;
                p = p.link;
            }
            DisplayList();
        }
        public void ReverseList(){
            node prev, p, next;
            prev = null;
            p = start;
            while(p!=null){
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
            DisplayList();
        }

        
         public void BubbleSort(){
            node p, q, end;
            p = start;
            q = p.link;
            end = null;
            var temp=0;
            while(start!=end){
                while(p.link != end){
                    if (p.info > q.info){
                        temp = p.info;
                        p.info = q.info;
                        q.info = temp;                       
                   }
                    p = p.link;
                    q = q.link;
                }
                end = p;
                p = start;
                q = p.link;
            }
            DisplayList();
        }

        public void BubbleSortByExLinks(){
            node p, q, end, r;
            p = start;
            r = start;
            q = p.link;
            node temp;
            for(end = null;end!=start.link; end= p){
                for(p = r = start;p.link != end; r=p,p=p.link){
                    q=p.link;
                    if (p.info > q.info){
                        p.link = q.link;
                        q.link = p;
                        if(p!=start)
                            r.link = q;
                        else
                            start = q;   
                        temp = p;
                        p = q;
                        q= temp;                    
                   }
                }
               }
            DisplayList();
        }
        public SingleLinkedList MergeLinkedList(SingleLinkedList list2){
            node p1,p2,pM;
            p1 = this.start;
            p2 = list2.start;
            SingleLinkedList merged = new SingleLinkedList();
            if (p1.info < p2.info){
                merged.start = new node(p1.info);
            }
            else{
                merged.start = new node(p2.info);
            }
            pM = merged.start;
            p1 = p1.link;
            p2 = p2.link;
            while(p1!=null || p2!=null){
                if (p1.info < p2.info){
                    pM.link = new node(p1.info);
                    p1 = p1.link;
                }
                else{
                    pM.link = new node(p2.info);
                    p2 = p2.link;
                }
                pM = pM.link;

            }
           return merged;
        }
    }
}