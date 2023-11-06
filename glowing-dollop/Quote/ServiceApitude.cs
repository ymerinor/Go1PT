using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Quote.Contracts;
using Quote.Models.Provider;

namespace Quote
{
    public class ServiceApitude : IServiceWrapper
    {
        public Task<ActivitiesDetailResponse> GetDetails(ActivitiesDetailRequest request)
        {
            var resultQuestions =
                @"
{
    'operationId': '6ed8beb064f38b55',
    'auditData': {
        'processTime': 0.0,
        'time': '2022-03-18T16:23:50.936Z',
        'serverId': 'blank',
        'environment': 'blank'
    },
    'activity': {
        'activityCode': 'PRVPARKTRF',
        'country': {
            'code': 'US',
            'name': 'Estados Unidos',
            'destinations': [
                {
                    'code': 'MCO',
                    'name': 'Orlando Area - FL'
                }
            ]
        },
        'operationDays': [
            {
                'code': 'MON',
                'name': 'lunes'
            },
            {
                'code': 'TUE',
                'name': 'martes'
            },
            {
                'code': 'WED',
                'name': 'miércoles'
            },
            {
                'code': 'THU',
                'name': 'jueves'
            },
            {
                'code': 'FRI',
                'name': 'viernes'
            },
            {
                'code': 'SAT',
                'name': 'sábado'
            },
            {
                'code': 'SUN',
                'name': 'domingo'
            }
        ],
        'modalities': [
            {
                'code': '726479001',
                'name': 'Magic Kingdom',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias: 1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8307,
                    'name': '21PRVTHEMEDISNE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'd9p72mu9viq9dm6b3btlb4s6ub',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '726479001'
            },
            {
                'code': '102955431',
                'name': 'EPCOT',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias: 1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8307,
                    'name': '21PRVTHEMEDISNE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'q0vtee25ipmechtigvahqgvtvk',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '102955431'
            },
            {
                'code': '572908162',
                'name': 'Hollywood Studios',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias: 1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8307,
                    'name': '21PRVTHEMEDISNE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'tapsvuddkkojfio7rj1g0jefnr',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '572908162'
            },
            {
                'code': '166469627',
                'name': 'Animal Kingdom',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias: 1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8307,
                    'name': '21PRVTHEMEDISNE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'chckqikh7pnlfmjcij0m66r1cn',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '166469627'
            },
            {
                'code': '480136756',
                'name': 'Disney Springs (regreso antes de las 00:30 horas)',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias: 1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8307,
                    'name': '21PRVTHEMEDISNE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'a91ctfo0ph3maifaj318pt4mnp',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '480136756'
            },
            {
                'code': '850044274',
                'name': 'Universal Studios y Islands of Adventure',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation // Número de teléfono de emergencias: 1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8311,
                    'name': 'PRVTHEMEUNIV21'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'ihtj5rruso8a6bong8dsg7cnvg',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '850044274'
            },
            {
                'code': '1248107642',
                'name': 'SeaWorld',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias:  1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8310,
                    'name': 'PRVTHEMESAD21'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': '1s35rtso6m88ft45q8ke3lqsnt',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1248107642'
            },
            {
                'code': '12393727',
                'name': 'Discovery Cove',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation  // Número de teléfono de emergencias:  1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8310,
                    'name': 'PRVTHEMESAD21'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 91.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'mht04mbrap4fg1mp4d9h8dkhbt',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 91.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 91.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 91.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '12393727'
            },
            {
                'code': '1722342066',
                'name': 'Kennedy Space Center',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation // Número de teléfono de emergencias:  1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad. // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8309,
                    'name': '21PRVTHEMEKSCLE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 270.42,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'tqpfjkkgf5b5qk1cfgbkfs8g4b',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 270.4200
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 270.42,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 270.42,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1722342066'
            },
            {
                'code': '1774681147',
                'name': 'Busch Gardens (10:00 - 19:00 horas)',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation // Número de teléfono de emergencias:  1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8308,
                    'name': '21PRVTHEMEBUSCH'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 329.67,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': '3rgdg40ud77uu82b9dsn82fu0o',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 329.6700
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 329.67,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 329.67,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1774681147'
            },
            {
                'code': '1333910402',
                'name': 'Legoland',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation // Número de teléfono de emergencias:  1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad. // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8309,
                    'name': '21PRVTHEMEKSCLE'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 270.42,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': '2givkbrkc87ootjpmv16lfum5f',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 270.4200
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 270.42,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 270.42,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1333910402'
            },
            {
                'code': '522718075',
                'name': 'Busch Gardens (9:00 - 18:00 horas)',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [
                    {
                        'code': 'HOTEL_NAME',
                        'text': 'Por favor, indique en qué hotel está vd. alojado.',
                        'required': true
                    },
                    {
                        'code': 'IDIOMA',
                        'text': 'Por favor, indique el idioma en el que quiere que se realice la excursión, según los idiomas disponibles en la ficha descriptiva',
                        'required': true
                    }
                ],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Punto de encuentro: Todas las recogidas están con un horario preestablecido, así que por lo tanto no habrán recogidas de último minuto // Instrucciones punto de encuentro: Por favor de llamar a MCA Transportation con al menos 24 horas de anticipación al cualquiera de los siguientes número  (+1) 877-705-1010 para programar el horario de la recogida en su hotel.  // Instrucciones obligatorias: Recuerda llevar el bono y un documento de identidad con fotografía válido // Proveedor: MCA Transportation // Número de teléfono de emergencias:  1-407-352-9464 // Tipo de bono: Bono impreso. Imprime y lleva el bono para disfrutar de la actividad // Validez de bono: Fecha del servicio // \t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n\t\t\t\t\t\n'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'MCA TRANSPORTATION'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8308,
                    'name': '21PRVTHEMEBUSCH'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 0,
                        'ageTo': 999,
                        'amount': 270.42,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'ta0bbdhn3aur81k3qdj5bahqbe',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-25T00:00:00.000Z',
                                                'amount': 270.4200
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 270.42,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 0,
                                        'ageTo': 999,
                                        'amount': 270.42,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '522718075'
            }
        ],
        'currencyName': 'Euro',
        'amountsFrom': [
            {
                'paxType': 'ADULT',
                'ageFrom': 0,
                'ageTo': 999,
                'amount': 91.58,
                'boxOfficeAmount': 0.00,
                'mandatoryApplyAmount': false
            }
        ],
        'content': {
            'name': 'Traslados privados de ida y vuelta a parques temáticos',
            'detailedInfo': [],
            'featureGroups': [
                {
                    'groupCode': 'TRANSPORT',
                    'included': [
                        {
                            'featureType': 'TRANSPORTINCL',
                            'description': 'Transport'
                        }
                    ]
                }
            ],
            'location': {
                'endPoints': [
                    {
                        'type': 'Same',
                        'description': 'Same as Starting Point'
                    }
                ],
                'startingPoints': [
                    {
                        'type': 'HOTEL_PICKUP',
                        'meetingPoint': {
                            'type': 'ADDRESS',
                            'country': {
                                'code': 'US',
                                'name': 'Estados Unidos',
                                'destinations': [
                                    {
                                        'code': 'MCO',
                                        'name': 'Orlando Area - FL'
                                    }
                                ]
                            },
                            'description': 'Traslados privados de ida y vuelta a parques temáticos'
                        },
                        'pickupInstructions': [
                            {
                                'description': 'Hoteles en la zona de Orlando - International Drive, 192 West, Lake Buena Vista o Walt Disney World.</br> Si desea una ubicación específica de recogida, pueden aplicarse cargos adicionales y se abonan en el lugar.</br> Es necesario confirmar lugar y horario de recogida con 24 horas de antelación</br>'
                            }
                        ]
                    }
                ]
            },
            'media': {
                'images': [
                    {
                        'visualizationOrder': 1,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/S/28416_3.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/XL/28416_3.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/B/28416_3.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/LPP/28416_3.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/L/28416_3.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/M/28416_3.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 2,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/S/28416_2.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/XL/28416_2.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/B/28416_2.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/LPP/28416_2.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/L/28416_2.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/M/28416_2.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 3,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/S/28416_5.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/XL/28416_5.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/B/28416_5.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/LPP/28416_5.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/L/28416_5.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/M/28416_5.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 4,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/S/28416_4.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/XL/28416_4.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/B/28416_4.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/LPP/28416_4.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/L/28416_4.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28416/ENG/M/28416_4.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    }
                ]
            },
            'notes': [
                {
                    'dateFrom': '2020-03-01',
                    'dateTo': '2021-12-31',
                    'visibleFrom': '2020-03-01',
                    'visibleTo': '2021-12-31',
                    'descriptions': [
                        {
                            'description': 'Como resultado de las medidas de los gobiernos locales establecidas por proveedores de servicios -incluidos hoteles y actividades- algunas instalaciones o servicios pueden que no  estén disponibles. Para más información visita https://corporate.hotelbeds.com/hotelbeds-update-covid-19'
                        }
                    ]
                }
            ],
            'redeemInfo': {
                'type': 'PRINTED',
                'directEntrance': false,
                'comments': [
                    {
                        'description': 'Bono impreso. Imprime y lleva el bono para disfrutar de la actividad.'
                    }
                ]
            },
            'routes': [],
            'scheduling': {},
            'segmentationGroups': [
                {
                    'code': 3,
                    'name': 'Actividad recomendada para',
                    'segments': [
                        {
                            'code': 778,
                            'name': 'Familias '
                        },
                        {
                            'code': 780,
                            'name': 'Jóvenes'
                        },
                        {
                            'code': 777,
                            'name': 'Parejas'
                        },
                        {
                            'code': 779,
                            'name': 'Sénior'
                        }
                    ]
                },
                {
                    'code': 16,
                    'name': 'Servicios',
                    'segments': [
                        {
                            'code': 946,
                            'name': 'Privado'
                        },
                        {
                            'code': 956,
                            'name': 'Safe2Stay'
                        }
                    ]
                },
                {
                    'code': 1,
                    'name': 'Categorías',
                    'segments': [
                        {
                            'code': 2,
                            'name': 'Parques de atracciones'
                        },
                        {
                            'code': 12,
                            'name': 'Transporte y alquileres'
                        }
                    ]
                },
                {
                    'code': 2,
                    'name': 'Duración',
                    'segments': [
                        {
                            'code': 771,
                            'name': 'Flexible'
                        }
                    ]
                }
            ],
            'activityFactsheetType': 'ACTIVITIES',
            'activityCode': 'E-U10-PRVPARKTRF',
            'modalityCode': 'ROUNDDD1',
            'modalityName': 'Disney Springs (regreso antes de las 00:30 horas)',
            'contentId': '28416',
            'description': 'Descripcion',
            'lastUpdate': '2020-06-30',
            'summary': 'Summary',
            'advancedTips': [],
            'countries': [
                {
                    'code': 'US',
                    'name': 'Estados Unidos',
                    'destinations': [
                        {
                            'code': 'MCO',
                            'name': 'Orlando Area - FL'
                        }
                    ]
                }
            ],
            'highligths': [
                'Ahorra tiempo y líbrate del estrés reservando traslados de ida y vuelta privados',
                'Vehículos con aire acondicionado',
                'Reserva la hora que más te convenga'
            ]
        },
        'order': 17,
        'name': 'Traslados privados de ida y vuelta a parques temáticos',
        'currency': 'EUR',
        'code': 'E-U10-PRVPARKTRF',
        'type': 'TICKET'
    }
}
";
            var result =
                @"
{
    'operationId': '63a1f671711bf4a8',
    'auditData': {
        'processTime': 0.0,
        'time': '2022-03-18T14:21:56.984Z',
        'serverId': 'blank',
        'environment': 'blank'
    },
    'activity': {
        'activityCode': 'SEAWRLDUK',
        'country': {
            'code': 'US',
            'name': 'United States',
            'destinations': [
                {
                    'code': 'MCO',
                    'name': 'Orlando Area - Florida - FL'
                }
            ]
        },
        'operationDays': [
            {
                'code': 'MON',
                'name': 'lunes'
            },
            {
                'code': 'TUE',
                'name': 'martes'
            },
            {
                'code': 'WED',
                'name': 'miércoles'
            },
            {
                'code': 'THU',
                'name': 'jueves'
            },
            {
                'code': 'FRI',
                'name': 'viernes'
            },
            {
                'code': 'SAT',
                'name': 'sábado'
            },
            {
                'code': 'SUN',
                'name': 'domingo'
            }
        ],
        'modalities': [
            {
                'code': '1273439531',
                'name': 'SeaWorld Orlando and Aquatica Combo',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Remarks'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'SEAWORLD OF ORLANDO, INC.'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8332,
                    'name': 'SWAQB2BUKMCO'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'CHILD',
                        'ageFrom': 3,
                        'ageTo': 9,
                        'amount': 147.74,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    },
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 10,
                        'ageTo': 999,
                        'amount': 151.87,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    },
                    {
                        'paxType': 'CHILD',
                        'ageFrom': 0,
                        'ageTo': 2,
                        'amount': 0.00,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': '3mi0m6b134olu8mf7gr01iqin0',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-26T00:00:00.000Z',
                                                'amount': 151.8700
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 151.87,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'CHILD',
                                        'ageFrom': 0,
                                        'ageTo': 2,
                                        'amount': 0.00,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    },
                                    {
                                        'paxType': 'CHILD',
                                        'ageFrom': 3,
                                        'ageTo': 9,
                                        'amount': 147.74,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    },
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 10,
                                        'ageTo': 999,
                                        'amount': 151.87,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1273439531'
            },
            {
                'code': '1177021395',
                'name': 'SeaWorld Orlando, Aquatica and Busch Gardens Tampa Combo',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Remarks'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'SEAWORLD OF ORLANDO, INC.'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8334,
                    'name': 'SW3PB2BUKMCO'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'CHILD',
                        'ageFrom': 3,
                        'ageTo': 9,
                        'amount': 148.55,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    },
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 10,
                        'ageTo': 999,
                        'amount': 152.54,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    },
                    {
                        'paxType': 'CHILD',
                        'ageFrom': 0,
                        'ageTo': 2,
                        'amount': 0.00,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'faf3863urh1bh1a0kq90h1ior6',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-26T00:00:00.000Z',
                                                'amount': 152.5400
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 152.54,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'CHILD',
                                        'ageFrom': 0,
                                        'ageTo': 2,
                                        'amount': 0.00,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    },
                                    {
                                        'paxType': 'CHILD',
                                        'ageFrom': 3,
                                        'ageTo': 9,
                                        'amount': 148.55,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    },
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 10,
                                        'ageTo': 999,
                                        'amount': 152.54,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1177021395'
            },
            {
                'code': '1967519248',
                'name': 'SeaWorld Orlando and Busch Gardens Tampa Combo',
                'duration': {
                    'value': 1.0,
                    'metric': 'DAYS'
                },
                'questions': [],
                'comments': [
                    {
                        'type': 'CONTRACT_REMARKS',
                        'text': 'Remarks'
                    }
                ],
                'supplierInformation': {
                    'name': 'HOTELBEDS USA, INC',
                    'vatNumber': '592952685'
                },
                'providerInformation': {
                    'name': 'SEAWORLD OF ORLANDO, INC.'
                },
                'destinationCode': 'MCO',
                'contract': {
                    'incomingOffice': 235,
                    'code': 8333,
                    'name': 'SWBGB2BUKMCO'
                },
                'languages': [],
                'amountsFrom': [
                    {
                        'paxType': 'CHILD',
                        'ageFrom': 3,
                        'ageTo': 9,
                        'amount': 148.44,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    },
                    {
                        'paxType': 'ADULT',
                        'ageFrom': 10,
                        'ageTo': 999,
                        'amount': 152.58,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    },
                    {
                        'paxType': 'CHILD',
                        'ageFrom': 0,
                        'ageTo': 2,
                        'amount': 0.00,
                        'boxOfficeAmount': 0.00,
                        'mandatoryApplyAmount': false
                    }
                ],
                'rates': [
                    {
                        'rateCode': 'STANDARD',
                        'rateClass': 'NOR',
                        'name': '.',
                        'freeCancellation': false,
                        'rateDetails': [
                            {
                                'rateKey': 'ltaj414hn44s2mmcipk1ou3aor',
                                'operationDates': [
                                    {
                                        'from': '2022-04-28',
                                        'to': '2022-04-28',
                                        'cancellationPolicies': [
                                            {
                                                'dateFrom': '2022-04-26T00:00:00.000Z',
                                                'amount': 152.5800
                                            }
                                        ]
                                    }
                                ],
                                'languages': [],
                                'sessions': [],
                                'minimumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'maximumDuration': {
                                    'value': 1.0,
                                    'metric': 'DAYS'
                                },
                                'totalAmount': {
                                    'amount': 152.58,
                                    'boxOfficeAmount': 0.00,
                                    'mandatoryApplyAmount': false
                                },
                                'paxAmounts': [
                                    {
                                        'paxType': 'CHILD',
                                        'ageFrom': 0,
                                        'ageTo': 2,
                                        'amount': 0.00,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    },
                                    {
                                        'paxType': 'CHILD',
                                        'ageFrom': 3,
                                        'ageTo': 9,
                                        'amount': 148.44,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    },
                                    {
                                        'paxType': 'ADULT',
                                        'ageFrom': 10,
                                        'ageTo': 999,
                                        'amount': 152.58,
                                        'boxOfficeAmount': 0.00,
                                        'mandatoryApplyAmount': false
                                    }
                                ]
                            }
                        ]
                    }
                ],
                'amountUnitType': 'PAX',
                'uniqueIdentifier': '1967519248'
            }
        ],
        'currencyName': 'Euro',
        'amountsFrom': [
            {
                'paxType': 'CHILD',
                'ageFrom': 3,
                'ageTo': 9,
                'amount': 147.74,
                'boxOfficeAmount': 0.00,
                'mandatoryApplyAmount': false
            },
            {
                'paxType': 'ADULT',
                'ageFrom': 10,
                'ageTo': 999,
                'amount': 151.87,
                'boxOfficeAmount': 0.00,
                'mandatoryApplyAmount': false
            },
            {
                'paxType': 'CHILD',
                'ageFrom': 0,
                'ageTo': 2,
                'amount': 0.00,
                'boxOfficeAmount': 0.00,
                'mandatoryApplyAmount': false
            }
        ],
        'content': {
            'name': 'SeaWorld Parks',
            'detailedInfo': [],
            'featureGroups': [
                {
                    'groupCode': 'TICKET',
                    'included': [
                        {
                            'featureType': 'ADMISSIONSINCL',
                            'description': 'Tickets'
                        }
                    ]
                }
            ],
            'location': {
                'endPoints': [
                    {
                        'type': 'Same',
                        'description': 'Same as Starting Point'
                    }
                ],
                'startingPoints': [
                    {
                        'type': 'Attraction',
                        'meetingPoint': {
                            'type': 'ADDRESS',
                            'geolocation': {
                                'latitude': 28.411427,
                                'longitude': -81.461681
                            },
                            'address': '7007 Sea World Drive',
                            'country': {
                                'code': 'US',
                                'name': 'United States',
                                'destinations': [
                                    {
                                        'code': 'MCO',
                                        'name': 'Orlando Area - Florida - FL'
                                    }
                                ]
                            },
                            'city': 'Orlando',
                            'description': '7007 Sea World Drive'
                        }
                    }
                ]
            },
            'media': {
                'images': [
                    {
                        'visualizationOrder': 1,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/Cheetah-Hunt_BG_3-1.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/Cheetah-Hunt_BG_3-1.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/Cheetah-Hunt_BG_3-1.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/Cheetah-Hunt_BG_3-1.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/Cheetah-Hunt_BG_3-1.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/Cheetah-Hunt_BG_3-1.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 2,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/Jungala_BG_1%20%281%29.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/Jungala_BG_1%20%281%29.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/Jungala_BG_1%20%281%29.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/Jungala_BG_1%20%281%29.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/Jungala_BG_1%20%281%29.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/Jungala_BG_1%20%281%29.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 3,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/Mako_KEY%20IMAGE%20%283%29.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/Mako_KEY%20IMAGE%20%283%29.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/Mako_KEY%20IMAGE%20%283%29.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/Mako_KEY%20IMAGE%20%283%29.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/Mako_KEY%20IMAGE%20%283%29.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/Mako_KEY%20IMAGE%20%283%29.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 4,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/Ray%20Rush_AQ.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/Ray%20Rush_AQ.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/Ray%20Rush_AQ.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/Ray%20Rush_AQ.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/Ray%20Rush_AQ.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/Ray%20Rush_AQ.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 5,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/28864_13.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/28864_13.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/28864_13.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/28864_13.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/28864_13.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/28864_13.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 6,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/28864_14.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/28864_14.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/28864_14.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/28864_14.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/28864_14.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/28864_14.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 7,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/28864_15.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/28864_15.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/28864_15.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/28864_15.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/28864_15.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/28864_15.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 8,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/28864_16.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/28864_16.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/28864_16.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/28864_16.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/28864_16.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/28864_16.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    },
                    {
                        'visualizationOrder': 9,
                        'mimeType': 'image/jpeg',
                        'language': 'ENG',
                        'urls': [
                            {
                                'dpi': 72,
                                'height': 75,
                                'width': 100,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/S/28864_17.jpg',
                                'sizeType': 'SMALL'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/XL/28864_17.jpg',
                                'sizeType': 'XLARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 480,
                                'width': 640,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/B/28864_17.jpg',
                                'sizeType': 'LARGE2'
                            },
                            {
                                'dpi': 72,
                                'height': 768,
                                'width': 1024,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/LPP/28864_17.jpg',
                                'sizeType': 'RAW'
                            },
                            {
                                'dpi': 72,
                                'height': 200,
                                'width': 267,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/L/28864_17.jpg',
                                'sizeType': 'LARGE'
                            },
                            {
                                'dpi': 72,
                                'height': 130,
                                'width': 173,
                                'resource': 'https://media.activitiesbank.com/28864/ENG/M/28864_17.jpg',
                                'sizeType': 'MEDIUM'
                            }
                        ]
                    }
                ]
            },
            'notes': [
                {
                    'dateFrom': '2020-03-01',
                    'dateTo': '2021-12-31',
                    'visibleFrom': '2020-03-01',
                    'visibleTo': '2021-12-31',
                    'descriptions': [
                        {
                            'description': 'As a result of local government measures and guidelines put in place by services providers – including hotels and ancillaries – guests may find that some facilities or services are not available. Please visit https://corporate.hotelbeds.com/hotelbeds-update-covid-19 for further information.'
                        }
                    ]
                }
            ],
            'redeemInfo': {
                'type': 'VOCUHERLESS',
                'directEntrance': false,
                'comments': [
                    {
                        'description': 'Printed voucher or E-voucher. Print and bring the voucher or show the voucher on your mobile device to enjoy the activity. '
                    }
                ]
            },
            'routes': [],
            'scheduling': {},
            'segmentationGroups': [
                {
                    'code': 16,
                    'name': 'Services',
                    'segments': [
                        {
                            'code': 956,
                            'name': 'Safe2Stay'
                        }
                    ]
                },
                {
                    'code': 1,
                    'name': 'Categories',
                    'segments': [
                        {
                            'code': 2,
                            'name': 'Amusement Parks'
                        }
                    ]
                },
                {
                    'code': 2,
                    'name': 'Duration',
                    'segments': [
                        {
                            'code': 765,
                            'name': 'Multiday'
                        }
                    ]
                }
            ],
            'activityFactsheetType': 'ATTRACCTIONS',
            'activityCode': 'E-U10-SEAWRLDUK',
            'modalityCode': 'SWBGAQ',
            'modalityName': '3 Parks for price of 2 SeaWorld, Aquatica and Busch Gardens',
            'contentId': '28864',
            'description': 'Descripcion',
            'lastUpdate': '2021-09-13',
            'advancedTips': [],
            'countries': [
                {
                    'code': 'US',
                    'name': 'United States',
                    'destinations': [
                        {
                            'code': 'MCO',
                            'name': 'Orlando Area - Florida - FL'
                        }
                    ]
                }
            ],
            'highligths': []
        },
        'order': 11,
        'name': 'SeaWorld Parks',
        'currency': 'EUR',
        'code': 'E-U10-SEAWRLDUK',
        'type': 'TICKET'
    }
}
";
            if (request.Code.Equals("E-U10-PRVPARKTRF"))
            {
                result = resultQuestions;
            }

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };
            var response = JsonConvert.DeserializeObject<ActivitiesDetailResponse>(result, serializerSettings);
            return Task.FromResult(response);
        }
    }
}
