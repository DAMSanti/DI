using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08 {
    internal enum OperacionEnum {
        SinOperacion,
        Suma,
        Resta,
        Multiplicacion,
        Division
    }
    internal class Calculadora {
        private float _cache;
        private float _visor;
        private OperacionEnum _operacion;
        public float Memoria { get; set; }

        public OperacionEnum Operacion {
            get { return _operacion; }
            set {
                if (_operacion == OperacionEnum.SinOperacion) {
                    _cache = _visor;
                } else {
                    Calcular();
                    _cache = _visor;
                }
                _operacion = value;
            }
        }
        public float Visor {
            get { return _visor; }
            set { _visor = value; }
        }

        private void Calcular() {
            switch (_operacion) {
                case OperacionEnum.Suma:
                    _visor = _cache + _visor;
                    break;
                case OperacionEnum.Resta:
                    _visor = _cache - _visor;
                    break;
                case OperacionEnum.Multiplicacion:
                    _visor = _cache * _visor;
                    break;
                case OperacionEnum.Division:
                    if (_visor != 0) {
                        _visor = _cache / _visor;
                    } else {
                        // Manejar división por cero si es necesario
                    }
                    break;
                case OperacionEnum.SinOperacion:
                    return;
            }
            _operacion = OperacionEnum.SinOperacion;
        }

        public void Borrar() {
            _cache = 0;
            _visor = 0;
            _operacion = OperacionEnum.SinOperacion;
        }
    }

}
