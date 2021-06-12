using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Mappers.Base
{
    public class GeneralInformationModelMapper: BaseMapper 
    {
        public List<GeneralInformationModel> GetModelsFromDTO(List<GeneralInformationDTO> generalInformationDTO)
        {
            if (generalInformationDTO != null)
            {
                return _mapper.Map<List<GeneralInformationModel>>(generalInformationDTO);
            }

            throw new ArgumentNullException("List general Information is null");
        }

        public GeneralInformationModel GetModelFromDTO(GeneralInformationDTO generalInformationDTO)
        {
            if (generalInformationDTO != null)
            {
                return _mapper.Map<GeneralInformationModel>(generalInformationDTO);
            }

            throw new ArgumentNullException("General Information is null");
        }

        public GeneralInformationDTO GetDTOFromModel(GeneralInformationModel generalInformationModel)
        {
            if (generalInformationModel != null)
            {
                return _mapper.Map<GeneralInformationDTO>(generalInformationModel);
            }

            throw new ArgumentNullException("General Information model is null");
        }
    }
}
