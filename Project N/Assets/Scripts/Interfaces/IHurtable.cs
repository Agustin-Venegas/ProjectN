using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Todo lo que es dañable implementa esto
public interface IHurtable
{
    bool IsAlive(); //debe regresar si sigue con vida

    bool Hurt(int d); //que hace con el damage recibido. debe regresar si muere.

    void Die(); //que pasa al morir
}
