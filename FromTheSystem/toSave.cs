using System;
using SystemManagement.System;
namespace FromTheSystem.SysteActions
{
    interface ISaveParking
    {
        public void saveParking(SystemParking id, bool status);

    }
}