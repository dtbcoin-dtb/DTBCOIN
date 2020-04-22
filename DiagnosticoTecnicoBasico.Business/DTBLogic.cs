using DiagnostivoTecnicoBasico.Model;
using DiagnostivoTecnicoBasico.Model.ConsultaDTB;
using DiagnostivoTecnicoBasico.Model.Request;
using DiagnostivoTecnicoBasico.Model.Response;
using DiagnostivoTecnicoBasico.Model.ResponseAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnosticoTecnicoBasico.Business
{
    public class DTBLogic
    {
        public static RequestDTB GetRequestDTB(DTBResponseEntity model, string idUnico, string idCliente, string idDomicilio)
        {
            List<RelatedProductTestReq> relatedProductTestReqList = new List<RelatedProductTestReq>();

            foreach (DTBProducto dTBProducto in model.Productos.ProductRef)
            {
                List<DTBProducto> DTBProductoList = new List<DTBProducto>();
                List<RealizingResourceTestReq> realizingResourceTestList = new List<RealizingResourceTestReq>();

                foreach (DTBEquipoReferencia dTBEquipoReferencia in dTBProducto.Equipos.EquipoRef)
                {
                    List<CharacteristicReq> characteristicReqList = new List<CharacteristicReq>()
                    {
                       new CharacteristicReq(){ name = "MAC", value = dTBEquipoReferencia.MAC },
                       new CharacteristicReq(){ name = "Serial", value = dTBEquipoReferencia.Serial },
                       new CharacteristicReq(){ name = "NroLinea", value = dTBEquipoReferencia.NroLinea },
                       new CharacteristicReq(){ name = "TipoEquipo", value = dTBEquipoReferencia.TipoEquipo },
                       new CharacteristicReq(){ name = "Marca", value = dTBEquipoReferencia.Marca },
                       new CharacteristicReq(){ name = "Modelo", value = dTBEquipoReferencia.Modelo }
                    };

                    RealizingResourceTestReq realizingResourceTest = new RealizingResourceTestReq()
                    {
                        name = dTBEquipoReferencia.TipoEquipo,
                        characteristic = characteristicReqList
                    };

                    realizingResourceTestList.Add(realizingResourceTest);
                }

                ProductReq productReq = new ProductReq(){ id = 1, name = "TELEFONÍA" };

                RelatedProductTestReq relatedProductTestReq = new RelatedProductTestReq()
                {
                    name = dTBProducto.Servicio,
                    product = productReq,
                    realizingResourceTest = realizingResourceTestList
                };

                relatedProductTestReqList.Add(relatedProductTestReq);
            }

            RequestDTB requestDTB = new RequestDTB()
            {
                name = idUnico,
                testSpecification = new TestSpecificationReq() { id = "DTB", name = "DIAGNOSTICO TECNICO BASICO", version = "V1" },
                customer = new CustomerReq() { id = idCliente },
                place = new PlaceReq() { id = idDomicilio },
                mode = "ONDEMAND",
                startDateTime = DateTime.Now.ToString("o"),
                characteristic = new List<CharacteristicReq>() { new CharacteristicReq() { name = "username", value = "user" }, new CharacteristicReq() { name = "application", value = "app" } },
                relatedProductTest = relatedProductTestReqList
            };

            return requestDTB;
        }

        public static List<ProductResponse> GetResponseDTB(ResponseDTB responseDTB)
        {
            List<ProductResponse> productResponseList = new List<ProductResponse>();
            List<RelatedProductTestRes> relatedProductTestList = responseDTB.relatedProductTest;

            foreach (RelatedProductTestRes relatedProductTest in relatedProductTestList)
            {
                List<ServicioResponse> servicioResponseList = new List<ServicioResponse>();

                foreach (TestDiagnosis testDiagnosis in relatedProductTest.testDiagnosis)
                {
                    ServicioResponse servicioResponse = new ServicioResponse()
                    {
                        name = testDiagnosis.name,
                        descripcion = testDiagnosis.verCode.descr,
                        severity = testDiagnosis.verCode.severity
                    };

                    servicioResponseList.Add(servicioResponse);
                }

                ProductResponse productResponse = new ProductResponse()
                {
                    name = relatedProductTest.name,
                    servicio = servicioResponseList
                };

                productResponseList.Add(productResponse);
            }

            return productResponseList;
        }
    }
}
