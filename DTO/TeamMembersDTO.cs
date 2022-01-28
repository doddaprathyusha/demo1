namespace KanbanBoard.DTO
{
    public class TeamMembersDTO
    {
        public long teammember_id { get; set; } //Primary key
        public string role { get; set; }  //Role of the persons
        public string teammemberName { get; set; } //Name of the supplier
        public string teammemberEmail { get; set; } //EmailId of the supplier 
        public string teammemberContanctNo { get; set; } //Contanct supplier of the farmer
        public string teammemberAddress { get; set; }  //Address of the supplier
    }
}
