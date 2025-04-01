namespace Bb.Interfaces
{

    public interface IVaultSecretResolver
    {

        string GetSecret(params string[] name);

    }


}
