module PricesTests

open Xunit
open PricesTypes
open PricesFunctions

[<Fact>]
let ``Adult price without discount`` () = 
    let adultTicketType = AdultTicket FeesOnly
    let adultCustomer = { MembershipType = Regular; Age = CustomerAge 47u }
    let youthTicketType = YouthTicket FeesOnly
    let youthCustomer = { MembershipType = Regular; Age = CustomerAge 14u }
    let childTicketType = ChildTicket FeesOnly
    let childCustomer = { MembershipType = Regular; Age = CustomerAge 4u }

    let adultPrice = Calculate adultTicketType adultCustomer
    let youthPrice = Calculate youthTicketType youthCustomer
    let childPrice = Calculate childTicketType childCustomer

    Assert.Equal<PriceAmount>(PriceAmount 1000m, adultPrice.Amount)
    Assert.Equal<PriceAmount>(PriceAmount 500m, youthPrice.Amount)
    Assert.Equal<PriceAmount>(PriceAmount 600m, childPrice.Amount)
