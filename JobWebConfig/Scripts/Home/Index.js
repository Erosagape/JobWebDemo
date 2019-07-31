function OpenForm(fname) {
    switch (fname) {
        case 'apps':
            window.open('/home/apps', '','');
            break;
        case 'customers':
            window.open('/home/customers', '','');
            break;
    }
}