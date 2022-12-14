// Interface for UserExpense, added editable variable for extended functionality
export interface UserExpense{
    id?: number,
    date?: Date,
    placeOfPurchase?: string,
    amountIncludingVAT?: number,
    vat?: number,
    reason?: string,
    members?: string,
    comment?: string,
    editable?: boolean 
}