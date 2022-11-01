using System;

namespace ConsoleDi
{
    public class BusinessLogicService
    {
        private IService iService;

        public BusinessLogicService(IService _iService)
        {
            this.iService = _iService;
            this.iService.GetFirstName();
            this.iService.GetLastName();
        }
    }
}
