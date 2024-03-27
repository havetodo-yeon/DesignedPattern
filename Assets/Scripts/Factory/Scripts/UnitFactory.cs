using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ������ ���� : ���丮(Factory) => ��ü�� �����ϴ� Ŭ����

// ���� ���丮 : �־��� �Է��� ������� �ٸ� ������ ��ü�� ��ȯ�ϴ� �޼ҵ尡 �����մϴ�.

// ���� ���丮 ����
// 1. ���ֿ� ���� ������ enum���� �ۼ��մϴ�.
public enum UnitType
{
    Vulture, SiegeTank, Goliath
}

public class UnitFactory
{
    //2. ������ �����ϴ� �޼ҵ带 ���� �޼ҵ�� �����մϴ�.
    public static Unit CreateUnit(UnitType type)
    {
        Unit unit = null;

        switch(type)
        {
            case UnitType.Vulture:
                unit = new Vulture();
                break;
            case UnitType.SiegeTank:
                unit = new SiegeTank();
                break;
            case UnitType.Goliath:
                unit = new Goliath();
                break;
        }
        return unit;
    }
}
