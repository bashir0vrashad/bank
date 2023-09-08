using ConsoleApp1;

Ceo ce1= new Ceo("Ilham","Quliyev",25,2000,"CEO CEO CEO");

Worker w1 = new Worker("Elnur","Hesenov",22,1000,"WORKER WORKER WORKER");
Worker w2 = new Worker("Qismet","Huseynov",22,1500,"WORKER WORKER WORKER");

Manager m1= new Manager("Ferid","Babayev",23,700,"MANAGER MANAGER MANAGER");

Credit k1 = new Credit(10000, 12, 10);

Client c1 = new Client("Elgun","Muxtarli",24,1400,"Oguz rayonu","Baki seheri",k1);


Bank b1 = new Bank();
b1.Name = "Kapital Bank";
b1.Bank_Ceo = ce1;
b1.workers.Add(w1);
b1.workers.Add(w2);
b1.clients.Add(c1);

b1.showAllCredit();
