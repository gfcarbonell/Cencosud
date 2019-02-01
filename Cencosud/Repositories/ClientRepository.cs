using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Cencosud.Models;
using Cencosud.ServiceReference1;

namespace Cencosud.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Client firstCall()
        {
            var client = new Client();


            QueryCustomerScoringRequest ClientRequest = new QueryCustomerScoringRequest();
            ClientRequest.QueryCustomerScoringRequestABM = new QueryCustomerScoringRequestABMType();
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader = new EBMHeaderType();

            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.EBMID = "1";
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.CreationDateTimeSpecified = false;
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.CreationDateTime = DateTime.Parse("2019-01-09 11:08:00");

            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Sender = new SenderType();
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Sender.Application = "Siebel";
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Sender.Country = "PE";
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Sender.BusinessUnit = "Banco Peru";
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Sender.LegalEntity = "";

            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Target = "";
            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.EBMTracking = new EBMTrackingType[] {
                new EBMTrackingType()
                {
                    FileName = "",
                    IntegrationCode = "",
                    ParentEBMID = "",
                    ReferenceID = "",
                }
            };

            ClientRequest.QueryCustomerScoringRequestABM.EBMHeader.Addressing = new EBMAddressingType[]{
                new EBMAddressingType()
                {
                    CorrelID = "",
                    ReplyToAddress = ""
                }
            };

            ClientRequest.QueryCustomerScoringRequestABM.DataArea = new QueryCustomerScoringABMDataAreaRequestType();
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest = new QueryCustomerScoringABMRequestType();
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.applicant = new ApplicantType[]
            {
                 new ApplicantType()
                 {
                     documentType = "1",
                     documentNumber = "07884043"
                 }
            };

            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application = new ApplicationType();
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application.decisioningRequestType = "Auto";
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application.processingRequestType = "DA";
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application.deliveryOptionCode = "Cencosud";
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application.submitterId = "";

            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application.applicationCrossReferenceId = "07884043";
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.application.flowType = "I";

            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.creditRequest = new CreditRequestType();
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.creditRequest.productCategory = "Metro";
            ClientRequest.QueryCustomerScoringRequestABM.DataArea.QueryCustomerScoringABMRequest.creditRequest.productCode = "Tarjeta";

            try
            {
                QueryCustomerScoringClient SerScore = new QueryCustomerScoringClient();
                var x = SerScore.QueryCustomerScoring(ClientRequest.QueryCustomerScoringRequestABM);
            }
            catch(CommunicationException e)
            {
                throw e;
            }
            catch (Exception e)
            {

                throw e;
            }

            return client;
        }

        public ICollection<Client> Get()
        {
            throw new NotImplementedException();
        }

        public Client getClient(int documentTypeId, string documentNumber, int UserId)
        {
            throw new NotImplementedException();
        }

        public Client Post(Client t)
        {
            throw new NotImplementedException();
        }

        public Client Put(Client t)
        {
            throw new NotImplementedException();
        }
    }
}