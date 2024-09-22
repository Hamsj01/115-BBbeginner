using System;
// başında büyük I varsa interfaces 

namespace Project24_Interface.Interfaces;

public interface IRepo //abstract a gerek kalmıyor interfacete
{
    public void Create();
    public void GetAll();
    public void GetById();
    public void Update();
    public void Delete();
}
