function OpenMenu(mnuID) {
    let mnuPath = '';
    let path = '/';
    switch (mnuID) {
        case 'AccountCode':
            mnuPath = path + 'Master/AccountCode';
            break;
        case 'Dashboard':
            mnuPath = path + 'Menu/Index';
            break;
        case 'Advance':
            mnuPath = path + 'Adv/Index';
            break;
        case 'AppQuo':
            mnuPath = path + 'JobOrder/QuoApprove';
            break;
        case 'AppAdvance':
            mnuPath = path + 'Adv/Approve';
            break;
        case 'PayAdvance':
            mnuPath = path + 'Adv/Payment';
            break;
        case 'Bank':
            mnuPath = path + 'Master/Bank';
            break;
        case 'BookAccount':
            mnuPath = path + 'Master/BookAccount';
            break;
        case 'Branch':
            mnuPath = path + 'Master/Branch';
            break;
        case 'Clearing':
            mnuPath = path + 'Clr/Index';
            break;
        case 'AppClearing':
            mnuPath = path + 'Clr/Approve';
            break;
        case 'RecvClear':
            mnuPath = path + 'Clr/Receive';
            break;
        case 'Constant':
            mnuPath = path + 'Config/Index';
            break;
        case 'CreateJob':
            mnuPath = path + 'JobOrder/CreateJob';
            break;
        case 'SearchJob':
            mnuPath = path + 'JobOrder/Index';
            break;
        case 'Country':
            mnuPath = path + 'Master/Country';
            break;
        case 'Currency':
            mnuPath = path + 'Master/Currency';
            break;
        case 'DeclareType':
            mnuPath = path + 'Master/DeclareType';
            break;
        case 'CustomsPort':
            mnuPath = path + 'Master/CustomsPort';
            break;
        case 'CustomsUnit':
            mnuPath = path + 'Master/CustomsUnit';
            break;
        case 'InterPort':
            mnuPath = path + 'Master/InterPort';
            break;
        case 'ServiceCode':
            mnuPath = path + 'Master/ServiceCode';
            break;
        case 'ServiceGroup':
            mnuPath = path + 'Master/ServiceGroup';
            break;
        case 'ServUnit':
            mnuPath = path + 'Master/ServUnit';
            break;
        case 'users':
            mnuPath = path + 'Master/Users';
            break;
        case 'UserAuth':
            mnuPath = path + 'Config/UserAuth';
            break;
        case 'venders':
            mnuPath = path + 'Master/Venders';
            break;
        case 'customers':
            mnuPath = path + 'Master/Customers';
            break;
        case 'GLNote':
            mnuPath = path + 'Acc/GLNote';
            break;
        case 'Voucher':
            mnuPath = path + 'Acc/Voucher';
            break;
        case 'WHTax':
            mnuPath = path + 'Acc/WHTax';
            break;
        case 'Invoice':
            mnuPath = path + 'Acc/Invoice';
            break;
        case 'Receipt':
            mnuPath = path + 'Acc/Receipt';
            break;
        case 'Billing':
            mnuPath = path + 'Acc/Billing';
            break;
        case 'Expense':
            mnuPath = path + 'Acc/Expense';
            break;
        case 'TaxInvoice':
            mnuPath = path + 'Acc/TaxInvoice';
            break;
        case 'CreditNote':
            mnuPath = path + 'Acc/CreditNote';
            break;
        case 'CreditAdv':
            mnuPath = path + 'Adv/CreditAdv';
            break;
        case 'Report':
            mnuPath = path + 'Report/Index';
            break;
        case 'Tracking1':
            mnuPath = path + 'Tracking/Index';
            break;
        case 'Tracking2':
            mnuPath = path + 'Tracking/PublicIndex';
            break;
        case 'Transport':
            mnuPath = path + 'JobOrder/Transport';
            break;
        case 'Quotation':
            mnuPath = path + 'JobOrder/Quotation';
            break;
        case 'Cheque':
            mnuPath = path + 'Acc/Cheque';
            break;
        case 'RecvInv':
            mnuPath = path + 'Acc/RecvInv';
            break;
        case 'Payment':
            mnuPath = path + 'Acc/Payment';
            break;
        case 'PettyCash':
            mnuPath = path + 'Acc/PettyCash';
            break;
        case 'Earnest':
            mnuPath = path + 'Clr/Earnest';
            break;
        case 'MasS':
            $('#dvMasS').modal('show');
            break;
        case 'MasG':
            $('#dvMasG').modal('show');
            break;
        case 'MasA':
            $('#dvMasA').modal('show');
            break;
        case 'Role':
            mnuPath = path + 'Config/Role';
            break;
        case 'BudgetPolicy':
            mnuPath = path + 'Master/BudgetPolicy';
            break;
        case 'vessel':
            mnuPath = path + 'Master/Vessel';
            break;
        case 'EstimateCost':
            mnuPath = path + 'Adv/EstimateCost';
            break;
        case 'Import':
            mnuPath = path + 'Report/Import';
            break;
        case 'Export':
            mnuPath = path + 'Report/Export';
            break;
        case 'Province':
            mnuPath = path + 'Master/Province';
            break;
        default:
            ShowMessage('Under Development, Coming soon!');
            break;
    }
    if (userID !== '') {
        if (mnuPath !== '') {
            //window.location.href = mnuPath;
            window.open(mnuPath, '', '');
        }
    } else {
        ShowMessage('Please login first');
    }
}