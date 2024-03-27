using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public enum UnitType1
{
    Marine, Firebat
}

public class BarrackFactory: MonoBehaviour
{
    public GameObject marine = null;
    public GameObject firebat = null;

    public GameObject createUnit(UnitType1 type)
    {
        GameObject unit = null;

        float x = Random.Range(0, 5);
        float z = Random.Range(0, 5);

        switch (type)
        {
            case UnitType1.Marine:
                unit = Instantiate(marine, new Vector3(x, 1.0f, z), Quaternion.identity);
                break;
            case UnitType1.Firebat:
                unit = Instantiate(firebat, new Vector3(x, 1.0f, z), Quaternion.identity);
                break;
        }
        return unit;
    }

}
