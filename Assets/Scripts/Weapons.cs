using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Abstract Weapons Class used by all usable weapons
 */
public abstract class Weapons : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract float useWeapon();
    public abstract void secureWeapon();
    public abstract string weaponName();

}
