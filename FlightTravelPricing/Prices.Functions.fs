module PricesFunctions

open PricesTypes

let Calculate (ticketType : TicketType) (customer : Customer) =
    match ticketType with
    | AdultTicket adultTicketType -> 
        let price = { Amount = PriceAmount 1000m; Currency = NOK }
        price
    | YouthTicket youthTicketType -> 
        let price = { Amount = PriceAmount 500m; Currency = NOK }
        price
    | ChildTicket childTicketType ->
        let price = { Amount = PriceAmount 600m; Currency= NOK }
        price


