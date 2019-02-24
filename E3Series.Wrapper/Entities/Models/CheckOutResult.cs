namespace E3Series.Wrapper.Entities.Models
{
    public enum CheckOutResult
    {
        Ok = 1,
        CouldNotBeCheckedOut = -1,
        InternalErrorDuringUpdate = 1,
        InternalErrorDuringCheckOut = 2
    }
}