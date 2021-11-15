using MatData.Models.Records;

namespace MatData.Serialization
{
    public  class Q26Mapper
    {
        public static dynamic Serialize(Q26Record model)
        {
            if (model.q2607 == "Erosão")
            {
                return new
                {
                    NomeLocalSujeitoAcidenteNatural = model.q2606,
                    TipoArea = model.q2607,
                    Localizacao = model.q2608,
                    Fotografia1 = model.q2609,
                    Fotografia2 = model.q2610,
                    ExtensaoAreaSujeita = model.q2611,
                    Observacoes = model.q2620
                };
            }

            if (model.q2607 == "Deslizamento-de-terra")
            {
                return new
                {
                    NomeLocalSujeitoAcidenteNatural = model.q2606,
                    TipoArea = model.q2607,
                    Localizacao = model.q2612,
                    Fotografia1 = model.q2613,
                    Fotografia2 = model.q2614,
                    ExtensaoAreaSujeita = model.q2615,
                    Observacoes = model.q2620
                };
            }

            if (model.q2607 == "Inundações")
            {
                return new
                {
                    NomeLocalSujeitoAcidenteNatural = model.q2606,
                    TipoArea = model.q2607,
                    Localizacao = model.q2616,
                    Fotografia1 = model.q2617,
                    Fotografia2 = model.q2618,
                    ExtensaoAreaSujeita = model.q2619,
                    Observacoes = model.q2620
                };
            }

            return null;
        }
    }
}
